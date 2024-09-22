namespace App_Generadora_de_PseudoAleatorios_o_Algo_Asi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            panel1 = new Panel();
            lblProdMedSemilla2 = new Label();
            npdPorcentaje = new NumericUpDown();
            txtProdMedSemilla2 = new TextBox();
            lblConstante = new Label();
            lblPorcentaje = new Label();
            txtConstante = new TextBox();
            btnGenerarPseudo = new Button();
            lblDatos = new Label();
            npdCuantosNum = new NumericUpDown();
            lblCuantos = new Label();
            lblResultadoNumGen = new Label();
            lblMetodo = new Label();
            txtNumGen = new TextBox();
            rdbMulCons = new RadioButton();
            rdbProMe = new RadioButton();
            rdbCuaMed = new RadioButton();
            lblSemillaGen = new Label();
            txtSemillaGen = new TextBox();
            panel2 = new Panel();
            panel5 = new Panel();
            lblInversaChi = new Label();
            lblResultado = new Label();
            lblSumaChiCuadrado = new Label();
            dgvUniformidadRes = new DataGridView();
            clmLI = new DataGridViewTextBoxColumn();
            clmLS = new DataGridViewTextBoxColumn();
            clmOi = new DataGridViewTextBoxColumn();
            clmEi = new DataGridViewTextBoxColumn();
            clmEstaDistChi = new DataGridViewTextBoxColumn();
            label9 = new Label();
            lblUniformidad = new Label();
            lblPrubas = new Label();
            panel3 = new Panel();
            txtMedResu = new TextBox();
            label7 = new Label();
            txtMedLI = new TextBox();
            txtMedLS = new TextBox();
            lblLI = new Label();
            lblLS = new Label();
            lblMedia = new Label();
            panel4 = new Panel();
            label10 = new Label();
            txtVariResul = new TextBox();
            label8 = new Label();
            txtVariLI = new TextBox();
            label3 = new Label();
            txtVariLS = new TextBox();
            label4 = new Label();
            lblVariabilidad = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npdPorcentaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npdCuantosNum).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUniformidadRes).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(123, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(704, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Generador de Numeros PseudoAleatorios";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(lblProdMedSemilla2);
            panel1.Controls.Add(npdPorcentaje);
            panel1.Controls.Add(txtProdMedSemilla2);
            panel1.Controls.Add(lblConstante);
            panel1.Controls.Add(lblPorcentaje);
            panel1.Controls.Add(txtConstante);
            panel1.Controls.Add(btnGenerarPseudo);
            panel1.Controls.Add(lblDatos);
            panel1.Controls.Add(npdCuantosNum);
            panel1.Controls.Add(lblCuantos);
            panel1.Controls.Add(lblResultadoNumGen);
            panel1.Controls.Add(lblMetodo);
            panel1.Controls.Add(txtNumGen);
            panel1.Controls.Add(rdbMulCons);
            panel1.Controls.Add(rdbProMe);
            panel1.Controls.Add(rdbCuaMed);
            panel1.Controls.Add(lblSemillaGen);
            panel1.Controls.Add(txtSemillaGen);
            panel1.Location = new Point(12, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 752);
            panel1.TabIndex = 1;
            // 
            // lblProdMedSemilla2
            // 
            lblProdMedSemilla2.AutoSize = true;
            lblProdMedSemilla2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdMedSemilla2.Location = new Point(239, 167);
            lblProdMedSemilla2.Name = "lblProdMedSemilla2";
            lblProdMedSemilla2.Size = new Size(80, 21);
            lblProdMedSemilla2.TabIndex = 35;
            lblProdMedSemilla2.Text = "Semilla 2";
            // 
            // npdPorcentaje
            // 
            npdPorcentaje.Location = new Point(27, 471);
            npdPorcentaje.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            npdPorcentaje.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            npdPorcentaje.Name = "npdPorcentaje";
            npdPorcentaje.Size = new Size(186, 23);
            npdPorcentaje.TabIndex = 39;
            npdPorcentaje.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtProdMedSemilla2
            // 
            txtProdMedSemilla2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProdMedSemilla2.Location = new Point(239, 191);
            txtProdMedSemilla2.Name = "txtProdMedSemilla2";
            txtProdMedSemilla2.Size = new Size(144, 23);
            txtProdMedSemilla2.TabIndex = 34;
            // 
            // lblConstante
            // 
            lblConstante.AutoSize = true;
            lblConstante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConstante.Location = new Point(239, 221);
            lblConstante.Name = "lblConstante";
            lblConstante.Size = new Size(87, 21);
            lblConstante.TabIndex = 31;
            lblConstante.Text = "Constante";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(27, 454);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(136, 15);
            lblPorcentaje.TabIndex = 42;
            lblPorcentaje.Text = "Porcentaje de confianza:";
            // 
            // txtConstante
            // 
            txtConstante.Location = new Point(239, 243);
            txtConstante.Name = "txtConstante";
            txtConstante.Size = new Size(144, 23);
            txtConstante.TabIndex = 30;
            // 
            // btnGenerarPseudo
            // 
            btnGenerarPseudo.Location = new Point(278, 429);
            btnGenerarPseudo.Name = "btnGenerarPseudo";
            btnGenerarPseudo.Size = new Size(131, 65);
            btnGenerarPseudo.TabIndex = 27;
            btnGenerarPseudo.Text = "Generar";
            btnGenerarPseudo.UseVisualStyleBackColor = true;
            btnGenerarPseudo.Click += btnGenerarPseudo_Click;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatos.Location = new Point(183, 11);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(69, 30);
            lblDatos.TabIndex = 21;
            lblDatos.Text = "Datos";
            // 
            // npdCuantosNum
            // 
            npdCuantosNum.Location = new Point(27, 428);
            npdCuantosNum.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            npdCuantosNum.Name = "npdCuantosNum";
            npdCuantosNum.Size = new Size(186, 23);
            npdCuantosNum.TabIndex = 20;
            // 
            // lblCuantos
            // 
            lblCuantos.AutoSize = true;
            lblCuantos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCuantos.Location = new Point(27, 394);
            lblCuantos.Name = "lblCuantos";
            lblCuantos.Size = new Size(160, 21);
            lblCuantos.TabIndex = 19;
            lblCuantos.Text = "¿Cuantos Numeros?";
            lblCuantos.Click += lblCuantos_Click;
            // 
            // lblResultadoNumGen
            // 
            lblResultadoNumGen.AutoSize = true;
            lblResultadoNumGen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoNumGen.Location = new Point(27, 509);
            lblResultadoNumGen.Name = "lblResultadoNumGen";
            lblResultadoNumGen.Size = new Size(264, 21);
            lblResultadoNumGen.TabIndex = 18;
            lblResultadoNumGen.Text = "Resultado de numeros generados";
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodo.Location = new Point(136, 50);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(170, 21);
            lblMetodo.TabIndex = 17;
            lblMetodo.Text = "Seleccion de Metodo";
            // 
            // txtNumGen
            // 
            txtNumGen.Location = new Point(27, 533);
            txtNumGen.Multiline = true;
            txtNumGen.Name = "txtNumGen";
            txtNumGen.Size = new Size(393, 192);
            txtNumGen.TabIndex = 16;
            // 
            // rdbMulCons
            // 
            rdbMulCons.AutoSize = true;
            rdbMulCons.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbMulCons.Location = new Point(27, 236);
            rdbMulCons.Name = "rdbMulCons";
            rdbMulCons.Size = new Size(186, 24);
            rdbMulCons.TabIndex = 15;
            rdbMulCons.TabStop = true;
            rdbMulCons.Text = "Multiplicador Constante";
            rdbMulCons.UseVisualStyleBackColor = true;
            rdbMulCons.CheckedChanged += rdbMulCons_CheckedChanged;
            // 
            // rdbProMe
            // 
            rdbProMe.AutoSize = true;
            rdbProMe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbProMe.Location = new Point(27, 188);
            rdbProMe.Name = "rdbProMe";
            rdbProMe.Size = new Size(146, 24);
            rdbProMe.TabIndex = 14;
            rdbProMe.TabStop = true;
            rdbProMe.Text = "Productos Medios";
            rdbProMe.UseVisualStyleBackColor = true;
            rdbProMe.CheckedChanged += rdbProMe_CheckedChanged;
            // 
            // rdbCuaMed
            // 
            rdbCuaMed.AutoSize = true;
            rdbCuaMed.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbCuaMed.Location = new Point(27, 138);
            rdbCuaMed.Name = "rdbCuaMed";
            rdbCuaMed.Size = new Size(155, 24);
            rdbCuaMed.TabIndex = 13;
            rdbCuaMed.TabStop = true;
            rdbCuaMed.Text = " Cuadrados Medios";
            rdbCuaMed.UseVisualStyleBackColor = true;
            rdbCuaMed.CheckedChanged += rdbCuaMed_CheckedChanged;
            // 
            // lblSemillaGen
            // 
            lblSemillaGen.AutoSize = true;
            lblSemillaGen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemillaGen.Location = new Point(239, 115);
            lblSemillaGen.Name = "lblSemillaGen";
            lblSemillaGen.Size = new Size(67, 21);
            lblSemillaGen.TabIndex = 12;
            lblSemillaGen.Text = "Semilla";
            // 
            // txtSemillaGen
            // 
            txtSemillaGen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSemillaGen.Location = new Point(239, 139);
            txtSemillaGen.Name = "txtSemillaGen";
            txtSemillaGen.Size = new Size(144, 23);
            txtSemillaGen.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(lblPrubas);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(474, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 752);
            panel2.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblInversaChi);
            panel5.Controls.Add(lblResultado);
            panel5.Controls.Add(lblSumaChiCuadrado);
            panel5.Controls.Add(dgvUniformidadRes);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(lblUniformidad);
            panel5.Location = new Point(30, 418);
            panel5.Name = "panel5";
            panel5.Size = new Size(572, 292);
            panel5.TabIndex = 34;
            // 
            // lblInversaChi
            // 
            lblInversaChi.AutoSize = true;
            lblInversaChi.Location = new Point(388, 220);
            lblInversaChi.Name = "lblInversaChi";
            lblInversaChi.Size = new Size(81, 15);
            lblInversaChi.TabIndex = 40;
            lblInversaChi.Text = "inversa de Chi";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(3, 253);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(45, 15);
            lblResultado.TabIndex = 39;
            lblResultado.Text = "Si o No";
            // 
            // lblSumaChiCuadrado
            // 
            lblSumaChiCuadrado.AutoSize = true;
            lblSumaChiCuadrado.Location = new Point(3, 220);
            lblSumaChiCuadrado.Name = "lblSumaChiCuadrado";
            lblSumaChiCuadrado.Size = new Size(59, 15);
            lblSumaChiCuadrado.TabIndex = 37;
            lblSumaChiCuadrado.Text = "Resultado";
            // 
            // dgvUniformidadRes
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUniformidadRes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUniformidadRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUniformidadRes.Columns.AddRange(new DataGridViewColumn[] { clmLI, clmLS, clmOi, clmEi, clmEstaDistChi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUniformidadRes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUniformidadRes.Location = new Point(3, 44);
            dgvUniformidadRes.Name = "dgvUniformidadRes";
            dgvUniformidadRes.Size = new Size(566, 173);
            dgvUniformidadRes.TabIndex = 38;
            // 
            // clmLI
            // 
            clmLI.HeaderText = "l.i. [";
            clmLI.Name = "clmLI";
            clmLI.ReadOnly = true;
            // 
            // clmLS
            // 
            clmLS.HeaderText = "L.S. )";
            clmLS.Name = "clmLS";
            clmLS.ReadOnly = true;
            // 
            // clmOi
            // 
            clmOi.HeaderText = "Oi";
            clmOi.Name = "clmOi";
            clmOi.ReadOnly = true;
            // 
            // clmEi
            // 
            clmEi.HeaderText = "EI";
            clmEi.Name = "clmEi";
            clmEi.ReadOnly = true;
            // 
            // clmEstaDistChi
            // 
            clmEstaDistChi.HeaderText = "(Ei-Oi)^2/EI";
            clmEstaDistChi.Name = "clmEstaDistChi";
            clmEstaDistChi.ReadOnly = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(146, 79);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 37;
            // 
            // lblUniformidad
            // 
            lblUniformidad.AutoSize = true;
            lblUniformidad.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUniformidad.Location = new Point(17, 11);
            lblUniformidad.Name = "lblUniformidad";
            lblUniformidad.Size = new Size(99, 21);
            lblUniformidad.TabIndex = 32;
            lblUniformidad.Text = "Uniformidad";
            // 
            // lblPrubas
            // 
            lblPrubas.AutoSize = true;
            lblPrubas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrubas.Location = new Point(253, 11);
            lblPrubas.Name = "lblPrubas";
            lblPrubas.Size = new Size(91, 30);
            lblPrubas.TabIndex = 38;
            lblPrubas.Text = "Pruebas";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtMedResu);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtMedLI);
            panel3.Controls.Add(txtMedLS);
            panel3.Controls.Add(lblLI);
            panel3.Controls.Add(lblLS);
            panel3.Controls.Add(lblMedia);
            panel3.Location = new Point(30, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(566, 169);
            panel3.TabIndex = 40;
            // 
            // txtMedResu
            // 
            txtMedResu.Enabled = false;
            txtMedResu.Location = new Point(414, 68);
            txtMedResu.Name = "txtMedResu";
            txtMedResu.Size = new Size(100, 23);
            txtMedResu.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(343, 71);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 33;
            label7.Text = "Resultado";
            // 
            // txtMedLI
            // 
            txtMedLI.Enabled = false;
            txtMedLI.Location = new Point(414, 133);
            txtMedLI.Name = "txtMedLI";
            txtMedLI.Size = new Size(100, 23);
            txtMedLI.TabIndex = 32;
            // 
            // txtMedLS
            // 
            txtMedLS.Enabled = false;
            txtMedLS.Location = new Point(414, 8);
            txtMedLS.Name = "txtMedLS";
            txtMedLS.Size = new Size(100, 23);
            txtMedLS.TabIndex = 31;
            // 
            // lblLI
            // 
            lblLI.AutoSize = true;
            lblLI.Location = new Point(380, 136);
            lblLI.Name = "lblLI";
            lblLI.Size = new Size(22, 15);
            lblLI.TabIndex = 30;
            lblLI.Text = "L.I.";
            // 
            // lblLS
            // 
            lblLS.AutoSize = true;
            lblLS.Location = new Point(377, 11);
            lblLS.Name = "lblLS";
            lblLS.Size = new Size(25, 15);
            lblLS.TabIndex = 29;
            lblLS.Text = "L.S.";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMedia.Location = new Point(17, 10);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(53, 21);
            lblMedia.TabIndex = 28;
            lblMedia.Text = "Media";
            // 
            // panel4
            // 
            panel4.Controls.Add(label10);
            panel4.Controls.Add(txtVariResul);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtVariLI);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtVariLS);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblVariabilidad);
            panel4.Location = new Point(30, 236);
            panel4.Name = "panel4";
            panel4.Size = new Size(566, 163);
            panel4.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 78);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 35;
            label10.Text = "Resultado";
            // 
            // txtVariResul
            // 
            txtVariResul.Enabled = false;
            txtVariResul.Location = new Point(411, 75);
            txtVariResul.Name = "txtVariResul";
            txtVariResul.Size = new Size(100, 23);
            txtVariResul.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(406, 79);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 35;
            // 
            // txtVariLI
            // 
            txtVariLI.Enabled = false;
            txtVariLI.Location = new Point(411, 129);
            txtVariLI.Name = "txtVariLI";
            txtVariLI.Size = new Size(100, 23);
            txtVariLI.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 137);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 32;
            label3.Text = "L.I.";
            // 
            // txtVariLS
            // 
            txtVariLS.Enabled = false;
            txtVariLS.Location = new Point(411, 16);
            txtVariLS.Name = "txtVariLS";
            txtVariLS.Size = new Size(100, 23);
            txtVariLS.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 16);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 31;
            label4.Text = "L.S.";
            // 
            // lblVariabilidad
            // 
            lblVariabilidad.AutoSize = true;
            lblVariabilidad.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVariabilidad.Location = new Point(17, 6);
            lblVariabilidad.Name = "lblVariabilidad";
            lblVariabilidad.Size = new Size(96, 21);
            lblVariabilidad.TabIndex = 30;
            lblVariabilidad.Text = "Variabilidad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 826);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "GNPSA";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npdPorcentaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)npdCuantosNum).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUniformidadRes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Panel panel1;
        private Label lblDatos;
        private NumericUpDown npdCuantosNum;
        private Label lblCuantos;
        private Label lblResultadoNumGen;
        private Label lblMetodo;
        private TextBox txtNumGen;
        private RadioButton rdbMulCons;
        private RadioButton rdbProMe;
        private RadioButton rdbCuaMed;
        private Label lblSemillaGen;
        private TextBox txtSemillaGen;
        private Panel panel2;
        private Panel panel5;
        private Label lblUniformidad;
        private Label label9;
        private Label lblConstante;
        private TextBox txtConstante;
        private Button btnGenerarPseudo;
        private DataGridView dgvUniformidadRes;
        private DataGridViewTextBoxColumn clmLI;
        private DataGridViewTextBoxColumn clmLS;
        private DataGridViewTextBoxColumn clmOi;
        private DataGridViewTextBoxColumn clmEi;
        private DataGridViewTextBoxColumn clmEstaDistChi;
        private NumericUpDown npdPorcentaje;
        private Label lblPrubas;
        private Label lblPorcentaje;
        private Panel panel3;
        private TextBox txtMedResu;
        private Label label7;
        private TextBox txtMedLI;
        private TextBox txtMedLS;
        private Label lblLI;
        private Label lblLS;
        private Label lblMedia;
        private Panel panel4;
        private Label label10;
        private TextBox txtVariResul;
        private Label label8;
        private TextBox txtVariLI;
        private Label label3;
        private TextBox txtVariLS;
        private Label label4;
        private Label lblVariabilidad;
        private Label lblProdMedSemilla2;
        private TextBox txtProdMedSemilla2;
        private Label lblSumaChiCuadrado;
        private Label lblResultado;
        private Label lblInversaChi;
    }
}
