namespace cadastroClienteProva.forms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.labelQTDFILHOSFUNC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSALFAT = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtCIDADE = new System.Windows.Forms.TextBox();
            this.txtQTDFILHOSFUNC = new System.Windows.Forms.TextBox();
            this.txtSALARIOFAT = new System.Windows.Forms.TextBox();
            this.rbPF = new System.Windows.Forms.RadioButton();
            this.rbPJ = new System.Windows.Forms.RadioButton();
            this.btCADASTRO = new System.Windows.Forms.Button();
            this.btLIMPAR = new System.Windows.Forms.Button();
            this.lvPF = new System.Windows.Forms.ListView();
            this.labelEMPRESA = new System.Windows.Forms.Label();
            this.lvPJ = new System.Windows.Forms.ListView();
            this.msktCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtEMPRESA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(154, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPFCNPJ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCPFCNPJ.Location = new System.Drawing.Point(158, 102);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(73, 23);
            this.labelCPFCNPJ.TabIndex = 1;
            this.labelCPFCNPJ.Text = "CPF:";
            // 
            // labelQTDFILHOSFUNC
            // 
            this.labelQTDFILHOSFUNC.AutoSize = true;
            this.labelQTDFILHOSFUNC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQTDFILHOSFUNC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelQTDFILHOSFUNC.Location = new System.Drawing.Point(12, 242);
            this.labelQTDFILHOSFUNC.Name = "labelQTDFILHOSFUNC";
            this.labelQTDFILHOSFUNC.Size = new System.Drawing.Size(231, 23);
            this.labelQTDFILHOSFUNC.TabIndex = 2;
            this.labelQTDFILHOSFUNC.Text = "QUANTIDADE FILHOS:";
            this.labelQTDFILHOSFUNC.Click += new System.EventHandler(this.labelQTDFILHOSFUNC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(137, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "CIDADE:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelSALFAT
            // 
            this.labelSALFAT.AutoSize = true;
            this.labelSALFAT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSALFAT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSALFAT.Location = new System.Drawing.Point(137, 287);
            this.labelSALFAT.Name = "labelSALFAT";
            this.labelSALFAT.Size = new System.Drawing.Size(105, 23);
            this.labelSALFAT.TabIndex = 4;
            this.labelSALFAT.Text = "SALÁRIO:";
            // 
            // txtNOME
            // 
            this.txtNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOME.Location = new System.Drawing.Point(275, 138);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(626, 30);
            this.txtNOME.TabIndex = 6;
            // 
            // txtCIDADE
            // 
            this.txtCIDADE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIDADE.Location = new System.Drawing.Point(275, 187);
            this.txtCIDADE.Name = "txtCIDADE";
            this.txtCIDADE.Size = new System.Drawing.Size(626, 30);
            this.txtCIDADE.TabIndex = 7;
            // 
            // txtQTDFILHOSFUNC
            // 
            this.txtQTDFILHOSFUNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTDFILHOSFUNC.Location = new System.Drawing.Point(275, 238);
            this.txtQTDFILHOSFUNC.Name = "txtQTDFILHOSFUNC";
            this.txtQTDFILHOSFUNC.Size = new System.Drawing.Size(626, 30);
            this.txtQTDFILHOSFUNC.TabIndex = 8;
            // 
            // txtSALARIOFAT
            // 
            this.txtSALARIOFAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSALARIOFAT.Location = new System.Drawing.Point(275, 283);
            this.txtSALARIOFAT.Name = "txtSALARIOFAT";
            this.txtSALARIOFAT.Size = new System.Drawing.Size(626, 30);
            this.txtSALARIOFAT.TabIndex = 9;
            // 
            // rbPF
            // 
            this.rbPF.AutoSize = true;
            this.rbPF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPF.ForeColor = System.Drawing.Color.DarkBlue;
            this.rbPF.Location = new System.Drawing.Point(42, 33);
            this.rbPF.Name = "rbPF";
            this.rbPF.Size = new System.Drawing.Size(142, 24);
            this.rbPF.TabIndex = 10;
            this.rbPF.TabStop = true;
            this.rbPF.Text = "Pessoa Física";
            this.rbPF.UseVisualStyleBackColor = true;
            this.rbPF.CheckedChanged += new System.EventHandler(this.rbPF_CheckedChanged);
            // 
            // rbPJ
            // 
            this.rbPJ.AutoSize = true;
            this.rbPJ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPJ.ForeColor = System.Drawing.Color.DarkBlue;
            this.rbPJ.Location = new System.Drawing.Point(211, 33);
            this.rbPJ.Name = "rbPJ";
            this.rbPJ.Size = new System.Drawing.Size(161, 24);
            this.rbPJ.TabIndex = 11;
            this.rbPJ.TabStop = true;
            this.rbPJ.Text = "Pessoa Jurídica";
            this.rbPJ.UseVisualStyleBackColor = true;
            this.rbPJ.CheckedChanged += new System.EventHandler(this.rbPJ_CheckedChanged);
            // 
            // btCADASTRO
            // 
            this.btCADASTRO.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btCADASTRO.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCADASTRO.Location = new System.Drawing.Point(275, 381);
            this.btCADASTRO.Name = "btCADASTRO";
            this.btCADASTRO.Size = new System.Drawing.Size(189, 44);
            this.btCADASTRO.TabIndex = 12;
            this.btCADASTRO.Text = "CADASTRO";
            this.btCADASTRO.UseVisualStyleBackColor = false;
            this.btCADASTRO.Click += new System.EventHandler(this.btCADASTRO_Click);
            // 
            // btLIMPAR
            // 
            this.btLIMPAR.BackColor = System.Drawing.Color.OrangeRed;
            this.btLIMPAR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLIMPAR.Location = new System.Drawing.Point(524, 381);
            this.btLIMPAR.Name = "btLIMPAR";
            this.btLIMPAR.Size = new System.Drawing.Size(190, 44);
            this.btLIMPAR.TabIndex = 13;
            this.btLIMPAR.Text = "LIMPAR";
            this.btLIMPAR.UseVisualStyleBackColor = false;
            this.btLIMPAR.Click += new System.EventHandler(this.btLIMPAR_Click);
            // 
            // lvPF
            // 
            this.lvPF.HideSelection = false;
            this.lvPF.Location = new System.Drawing.Point(42, 462);
            this.lvPF.Name = "lvPF";
            this.lvPF.Size = new System.Drawing.Size(859, 97);
            this.lvPF.TabIndex = 15;
            this.lvPF.UseCompatibleStateImageBehavior = false;
            // 
            // labelEMPRESA
            // 
            this.labelEMPRESA.AutoSize = true;
            this.labelEMPRESA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMPRESA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEMPRESA.Location = new System.Drawing.Point(63, 333);
            this.labelEMPRESA.Name = "labelEMPRESA";
            this.labelEMPRESA.Size = new System.Drawing.Size(179, 23);
            this.labelEMPRESA.TabIndex = 16;
            this.labelEMPRESA.Text = "NOME EMPRESA:";
            this.labelEMPRESA.Click += new System.EventHandler(this.label6_Click);
            // 
            // lvPJ
            // 
            this.lvPJ.HideSelection = false;
            this.lvPJ.Location = new System.Drawing.Point(42, 587);
            this.lvPJ.Name = "lvPJ";
            this.lvPJ.Size = new System.Drawing.Size(859, 97);
            this.lvPJ.TabIndex = 18;
            this.lvPJ.UseCompatibleStateImageBehavior = false;
            // 
            // msktCPFCNPJ
            // 
            this.msktCPFCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktCPFCNPJ.Location = new System.Drawing.Point(275, 95);
            this.msktCPFCNPJ.Name = "msktCPFCNPJ";
            this.msktCPFCNPJ.Size = new System.Drawing.Size(626, 30);
            this.msktCPFCNPJ.TabIndex = 17;
            // 
            // txtEMPRESA
            // 
            this.txtEMPRESA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMPRESA.Location = new System.Drawing.Point(275, 333);
            this.txtEMPRESA.Name = "txtEMPRESA";
            this.txtEMPRESA.Size = new System.Drawing.Size(626, 30);
            this.txtEMPRESA.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 696);
            this.Controls.Add(this.txtEMPRESA);
            this.Controls.Add(this.lvPJ);
            this.Controls.Add(this.msktCPFCNPJ);
            this.Controls.Add(this.labelEMPRESA);
            this.Controls.Add(this.lvPF);
            this.Controls.Add(this.btLIMPAR);
            this.Controls.Add(this.btCADASTRO);
            this.Controls.Add(this.rbPJ);
            this.Controls.Add(this.rbPF);
            this.Controls.Add(this.txtSALARIOFAT);
            this.Controls.Add(this.txtQTDFILHOSFUNC);
            this.Controls.Add(this.txtCIDADE);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.labelSALFAT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelQTDFILHOSFUNC);
            this.Controls.Add(this.labelCPFCNPJ);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.Label labelQTDFILHOSFUNC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSALFAT;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.TextBox txtCIDADE;
        private System.Windows.Forms.TextBox txtQTDFILHOSFUNC;
        private System.Windows.Forms.TextBox txtSALARIOFAT;
        private System.Windows.Forms.RadioButton rbPF;
        private System.Windows.Forms.RadioButton rbPJ;
        private System.Windows.Forms.Button btCADASTRO;
        private System.Windows.Forms.Button btLIMPAR;
        private System.Windows.Forms.ListView lvPF;
        private System.Windows.Forms.Label labelEMPRESA;
        private System.Windows.Forms.ListView lvPJ;
        private System.Windows.Forms.MaskedTextBox msktCPFCNPJ;
        private System.Windows.Forms.TextBox txtEMPRESA;
    }
}

