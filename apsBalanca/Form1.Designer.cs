namespace apsBalanca
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnMenuPeso = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelPeso = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProteinaValue = new System.Windows.Forms.Label();
            this.lblColesterolValue = new System.Windows.Forms.Label();
            this.lblCalcioValue = new System.Windows.Forms.Label();
            this.lblProteina = new System.Windows.Forms.Label();
            this.lblColesterol = new System.Windows.Forms.Label();
            this.lblCalcio = new System.Windows.Forms.Label();
            this.lblCarbo = new System.Windows.Forms.Label();
            this.lblCarboValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKG = new System.Windows.Forms.Label();
            this.btnCalibrar = new System.Windows.Forms.Button();
            this.cbAlimentos = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.panelPeso.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnSobre);
            this.panelMenu.Controls.Add(this.btnMenuPeso);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(121, 376);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSobre
            // 
            this.btnSobre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSobre.Enabled = false;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSobre.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(0, 84);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSobre.Size = new System.Drawing.Size(121, 37);
            this.btnSobre.TabIndex = 2;
            this.btnSobre.Text = "  Sobre";
            this.btnSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnMenuSobre_Click);
            // 
            // btnMenuPeso
            // 
            this.btnMenuPeso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPeso.FlatAppearance.BorderSize = 0;
            this.btnMenuPeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMenuPeso.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuPeso.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPeso.Image")));
            this.btnMenuPeso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPeso.Location = new System.Drawing.Point(0, 47);
            this.btnMenuPeso.Name = "btnMenuPeso";
            this.btnMenuPeso.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMenuPeso.Size = new System.Drawing.Size(121, 37);
            this.btnMenuPeso.TabIndex = 1;
            this.btnMenuPeso.Text = "  Pesar";
            this.btnMenuPeso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuPeso.UseVisualStyleBackColor = true;
            this.btnMenuPeso.Click += new System.EventHandler(this.btnMenuPeso_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(95)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(121, 47);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLogo.Location = new System.Drawing.Point(33, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(52, 32);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "BV";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlTitulo.Location = new System.Drawing.Point(121, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(544, 47);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(22, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(75, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // panelPeso
            // 
            this.panelPeso.BackColor = System.Drawing.Color.White;
            this.panelPeso.Controls.Add(this.tableLayoutPanel1);
            this.panelPeso.Controls.Add(this.groupBox1);
            this.panelPeso.Controls.Add(this.cbAlimentos);
            this.panelPeso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPeso.Location = new System.Drawing.Point(121, 47);
            this.panelPeso.Name = "panelPeso";
            this.panelPeso.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelPeso.Size = new System.Drawing.Size(544, 329);
            this.panelPeso.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblProteinaValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblColesterolValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCalcioValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProteina, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblColesterol, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCalcio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCarbo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCarboValue, 1, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(262, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 77);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // lblProteinaValue
            // 
            this.lblProteinaValue.AutoSize = true;
            this.lblProteinaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProteinaValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProteinaValue.Location = new System.Drawing.Point(112, 54);
            this.lblProteinaValue.Name = "lblProteinaValue";
            this.lblProteinaValue.Size = new System.Drawing.Size(16, 18);
            this.lblProteinaValue.TabIndex = 23;
            this.lblProteinaValue.Text = "0";
            this.lblProteinaValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblColesterolValue
            // 
            this.lblColesterolValue.AutoSize = true;
            this.lblColesterolValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblColesterolValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColesterolValue.Location = new System.Drawing.Point(112, 36);
            this.lblColesterolValue.Name = "lblColesterolValue";
            this.lblColesterolValue.Size = new System.Drawing.Size(16, 18);
            this.lblColesterolValue.TabIndex = 23;
            this.lblColesterolValue.Text = "0";
            this.lblColesterolValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCalcioValue
            // 
            this.lblCalcioValue.AutoSize = true;
            this.lblCalcioValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCalcioValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCalcioValue.Location = new System.Drawing.Point(112, 18);
            this.lblCalcioValue.Name = "lblCalcioValue";
            this.lblCalcioValue.Size = new System.Drawing.Size(16, 18);
            this.lblCalcioValue.TabIndex = 23;
            this.lblCalcioValue.Text = "0";
            this.lblCalcioValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProteina
            // 
            this.lblProteina.AutoSize = true;
            this.lblProteina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProteina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProteina.Location = new System.Drawing.Point(3, 54);
            this.lblProteina.Name = "lblProteina";
            this.lblProteina.Size = new System.Drawing.Size(63, 18);
            this.lblProteina.TabIndex = 6;
            this.lblProteina.Text = "Proteina";
            // 
            // lblColesterol
            // 
            this.lblColesterol.AutoSize = true;
            this.lblColesterol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblColesterol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColesterol.Location = new System.Drawing.Point(3, 36);
            this.lblColesterol.Name = "lblColesterol";
            this.lblColesterol.Size = new System.Drawing.Size(76, 18);
            this.lblColesterol.TabIndex = 4;
            this.lblColesterol.Text = "Colesterol";
            // 
            // lblCalcio
            // 
            this.lblCalcio.AutoSize = true;
            this.lblCalcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCalcio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCalcio.Location = new System.Drawing.Point(3, 18);
            this.lblCalcio.Name = "lblCalcio";
            this.lblCalcio.Size = new System.Drawing.Size(50, 18);
            this.lblCalcio.TabIndex = 2;
            this.lblCalcio.Text = "Cálcio";
            // 
            // lblCarbo
            // 
            this.lblCarbo.AutoSize = true;
            this.lblCarbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCarbo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCarbo.Location = new System.Drawing.Point(3, 0);
            this.lblCarbo.Name = "lblCarbo";
            this.lblCarbo.Size = new System.Drawing.Size(86, 18);
            this.lblCarbo.TabIndex = 0;
            this.lblCarbo.Text = "Carboidrato";
            // 
            // lblCarboValue
            // 
            this.lblCarboValue.AutoSize = true;
            this.lblCarboValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCarboValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCarboValue.Location = new System.Drawing.Point(112, 0);
            this.lblCarboValue.Name = "lblCarboValue";
            this.lblCarboValue.Size = new System.Drawing.Size(16, 18);
            this.lblCarboValue.TabIndex = 10;
            this.lblCarboValue.Text = "0";
            this.lblCarboValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.lblKG);
            this.groupBox1.Controls.Add(this.btnCalibrar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(27, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 296);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balança";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.lblKG.Location = new System.Drawing.Point(120, 131);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(82, 46);
            this.lblKG.TabIndex = 18;
            this.lblKG.Text = "KG";
            this.lblKG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalibrar
            // 
            this.btnCalibrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btnCalibrar.FlatAppearance.BorderSize = 0;
            this.btnCalibrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCalibrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalibrar.Location = new System.Drawing.Point(49, 203);
            this.btnCalibrar.Name = "btnCalibrar";
            this.btnCalibrar.Size = new System.Drawing.Size(111, 30);
            this.btnCalibrar.TabIndex = 19;
            this.btnCalibrar.Text = "Calcular";
            this.btnCalibrar.UseVisualStyleBackColor = false;
            this.btnCalibrar.Click += new System.EventHandler(this.btnCalibrar_Click);
            // 
            // cbAlimentos
            // 
            this.cbAlimentos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbAlimentos.ForeColor = System.Drawing.Color.Black;
            this.cbAlimentos.FormattingEnabled = true;
            this.cbAlimentos.Location = new System.Drawing.Point(262, 37);
            this.cbAlimentos.Name = "cbAlimentos";
            this.cbAlimentos.Size = new System.Drawing.Size(167, 24);
            this.cbAlimentos.TabIndex = 20;
            this.cbAlimentos.Text = "Selecione um alimento";
            this.cbAlimentos.SelectedIndexChanged += new System.EventHandler(this.cbAlimentos_SelectedIndexChanged);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F);
            this.txtPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.txtPeso.Location = new System.Drawing.Point(14, 74);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(188, 54);
            this.txtPeso.TabIndex = 20;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(665, 376);
            this.Controls.Add(this.panelPeso);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Balanca da Vida";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panelPeso.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMenuPeso;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSobre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel panelPeso;
        private System.Windows.Forms.Label lblTitulo;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Button btnCalibrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAlimentos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblProteinaValue;
        private System.Windows.Forms.Label lblColesterolValue;
        private System.Windows.Forms.Label lblCalcioValue;
        private System.Windows.Forms.Label lblProteina;
        private System.Windows.Forms.Label lblColesterol;
        private System.Windows.Forms.Label lblCalcio;
        private System.Windows.Forms.Label lblCarbo;
        private System.Windows.Forms.Label lblCarboValue;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtPeso;
    }
}

