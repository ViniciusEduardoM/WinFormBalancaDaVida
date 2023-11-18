using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apsBalanca
{
    public partial class FormPrincipal : Form
    {
        //  variaveis
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private List<Food> FoodValues = new List<Food>();
        //  Construtor
        public FormPrincipal()
        {
            InitializeComponent();
            random = new Random();
            btnMenuPeso_Click(btnMenuPeso, new EventArgs());

            PegarAlimentos();

            cbAlimentos.DataSource = FoodValues;

        }
        //  Metodos
        private Color SelectThemeColor()
        {
            int index = random.Next(Tema.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Tema.ColorList.Count);
            }
            tempIndex = index;
            string color = Tema.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {

                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCalibrar.BackColor = color;
                    txtPeso.ForeColor = color;
                    lblKG.ForeColor = color;
                    panelLogo.BackColor = Tema.ChangeColorBrightness(color, -0.3);
                    pnlTitulo.BackColor = color;
                    //btnOk.BackColor = color;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(50, 52, 77);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnMenuPeso_Click(object sender, EventArgs e)
        {
            //if (!serialPort.IsOpen)
            //    serialPort.Open();


            lblTitulo.Text = "Pesar";
            ActivateButton(sender);
            panelPeso.Show();
        }

        private void btnMenuSobre_Click(object sender, EventArgs e)
        {
            //if (serialPort.IsOpen)  
            //    serialPort.Close(); 

            lblTitulo.Text = "Sobre";
            ActivateButton(sender);
            panelPeso.Hide();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    //if (serialPort.IsOpen)
            //    //{
            //    //    lblPeso.Text = serialPort.ReadLine();
            //    //}
            //}
            //catch (Exception ex)
            //{
            //    lblPeso.Text = ex.Message;
            //}



            
        }

        private void btnCalibrar_Click(object sender, EventArgs e)
        {
            if (cbAlimentos.SelectedIndex != -1)
            {
                lblCarboValue.Text = (Convert.ToDouble(txtPeso.Text) * Convert.ToDouble(FoodValues[cbAlimentos.SelectedIndex].CarboidratoG)).ToString() + " g";
                lblProteinaValue.Text = (Convert.ToDouble(txtPeso.Text) * Convert.ToDouble(FoodValues[cbAlimentos.SelectedIndex].ProteinaG)).ToString() + " g";
                lblColesterolValue.Text = (Convert.ToDouble(txtPeso.Text) * Convert.ToDouble(Double.TryParse(FoodValues[cbAlimentos.SelectedIndex].ColesterolMg, out double coles) ? coles : 0) / 100).ToString() + " g";
                lblCalcioValue.Text = (Convert.ToDouble(txtPeso.Text) * Convert.ToDouble(FoodValues[cbAlimentos.SelectedIndex].CalcioMg) / 100).ToString() + " g";
            }
        }

        private void cbAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PegarAlimentos()
        {
            var client = new HttpClient();

            var a = client.GetAsync("https://localhost:7055/api/Food/All");

            a.Wait();

            var d = a.Result.Content.ReadAsStringAsync();

            d.Wait();

            FoodValues = JsonConvert.DeserializeObject<List<Food>>(d.Result);
        }

        public class Food
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("nome", NullValueHandling = NullValueHandling.Ignore)]
            public string Nome { get; set; }

            [JsonProperty("descricao", NullValueHandling = NullValueHandling.Ignore)]
            public string Descricao { get; set; }

            [JsonProperty("umidade", NullValueHandling = NullValueHandling.Ignore)]
            public string Umidade { get; set; }

            [JsonProperty("energia_kcal", NullValueHandling = NullValueHandling.Ignore)]
            public string EnergiaKcal { get; set; }

            [JsonProperty("proteina_g", NullValueHandling = NullValueHandling.Ignore)]
            public string ProteinaG { get; set; }

            [JsonProperty("colesterol_mg", NullValueHandling = NullValueHandling.Ignore)]
            public string ColesterolMg { get; set; }

            [JsonProperty("carboidrato_g", NullValueHandling = NullValueHandling.Ignore)]
            public string CarboidratoG { get; set; }

            [JsonProperty("fibra_g", NullValueHandling = NullValueHandling.Ignore)]
            public string FibraG { get; set; }

            [JsonProperty("calcio_mg", NullValueHandling = NullValueHandling.Ignore)]
            public string CalcioMg { get; set; }

            [JsonProperty("ferro_mg", NullValueHandling = NullValueHandling.Ignore)]
            public string FerroMg { get; set; }

            [JsonProperty("sodio_mg", NullValueHandling = NullValueHandling.Ignore)]
            public string SodioMg { get; set; }

            [JsonProperty("potassio_mg", NullValueHandling = NullValueHandling.Ignore)]
            public string PotassioMg { get; set; }

            [JsonProperty("vitaminaC_mg", NullValueHandling = NullValueHandling.Ignore)]
            public string VitaminaCMg { get; set; }

            [JsonProperty("saturados_g", NullValueHandling = NullValueHandling.Ignore)]
            public string SaturadosG { get; set; }

            [JsonProperty("monoinsaturados_g", NullValueHandling = NullValueHandling.Ignore)]
            public string MonoinsaturadosG { get; set; }

            [JsonProperty("poliinsaturados_g", NullValueHandling = NullValueHandling.Ignore)]
            public string PoliinsaturadosG { get; set; }

            public override string ToString()
            {
                return $"{Nome} {Descricao}";
            }
        }
    }
}
