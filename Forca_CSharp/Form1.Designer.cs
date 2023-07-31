namespace Forca_CSharp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPalavra = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTentadas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbFaltam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbErros = new System.Windows.Forms.Label();
            this.tbPalavra = new System.Windows.Forms.TextBox();
            this.btComeca = new System.Windows.Forms.Button();
            this.btTenta = new System.Windows.Forms.Button();
            this.mtLetra = new System.Windows.Forms.MaskedTextBox();
            this.pbPernaE = new System.Windows.Forms.PictureBox();
            this.pbPernaD = new System.Windows.Forms.PictureBox();
            this.pbBracoE = new System.Windows.Forms.PictureBox();
            this.pbBracoD = new System.Windows.Forms.PictureBox();
            this.pbCorpo = new System.Windows.Forms.PictureBox();
            this.pbCabeca = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPernaE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPernaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBracoE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBracoD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo da Forca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a Palavra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite uma letra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Palavra";
            // 
            // lbPalavra
            // 
            this.lbPalavra.AutoSize = true;
            this.lbPalavra.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalavra.Location = new System.Drawing.Point(124, 270);
            this.lbPalavra.Name = "lbPalavra";
            this.lbPalavra.Size = new System.Drawing.Size(27, 19);
            this.lbPalavra.TabIndex = 4;
            this.lbPalavra.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tentativas";
            // 
            // lbTentadas
            // 
            this.lbTentadas.AutoSize = true;
            this.lbTentadas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTentadas.Location = new System.Drawing.Point(124, 319);
            this.lbTentadas.Name = "lbTentadas";
            this.lbTentadas.Size = new System.Drawing.Size(27, 19);
            this.lbTentadas.TabIndex = 6;
            this.lbTentadas.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Faltam:";
            // 
            // lbFaltam
            // 
            this.lbFaltam.AutoSize = true;
            this.lbFaltam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFaltam.Location = new System.Drawing.Point(176, 372);
            this.lbFaltam.Name = "lbFaltam";
            this.lbFaltam.Size = new System.Drawing.Size(18, 19);
            this.lbFaltam.TabIndex = 8;
            this.lbFaltam.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Erros:";
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.Location = new System.Drawing.Point(176, 412);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(18, 19);
            this.lbErros.TabIndex = 10;
            this.lbErros.Text = "0";
            // 
            // tbPalavra
            // 
            this.tbPalavra.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPalavra.Location = new System.Drawing.Point(48, 100);
            this.tbPalavra.Name = "tbPalavra";
            this.tbPalavra.PasswordChar = '*';
            this.tbPalavra.Size = new System.Drawing.Size(100, 23);
            this.tbPalavra.TabIndex = 11;
            this.tbPalavra.TextChanged += new System.EventHandler(this.tbPalavra_TextChanged);
            // 
            // btComeca
            // 
            this.btComeca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComeca.Location = new System.Drawing.Point(179, 100);
            this.btComeca.Name = "btComeca";
            this.btComeca.Size = new System.Drawing.Size(75, 23);
            this.btComeca.TabIndex = 13;
            this.btComeca.Text = "Comecar";
            this.btComeca.UseVisualStyleBackColor = true;
            this.btComeca.Click += new System.EventHandler(this.btComeca_Click);
            // 
            // btTenta
            // 
            this.btTenta.Enabled = false;
            this.btTenta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTenta.Location = new System.Drawing.Point(179, 202);
            this.btTenta.Name = "btTenta";
            this.btTenta.Size = new System.Drawing.Size(75, 23);
            this.btTenta.TabIndex = 14;
            this.btTenta.Text = "Tentar";
            this.btTenta.UseVisualStyleBackColor = true;
            this.btTenta.Click += new System.EventHandler(this.btTenta_Click);
            // 
            // mtLetra
            // 
            this.mtLetra.Enabled = false;
            this.mtLetra.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtLetra.Location = new System.Drawing.Point(48, 202);
            this.mtLetra.Mask = "a";
            this.mtLetra.Name = "mtLetra";
            this.mtLetra.Size = new System.Drawing.Size(100, 23);
            this.mtLetra.TabIndex = 15;
            this.mtLetra.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtLetra_MaskInputRejected);
            // 
            // pbPernaE
            // 
            this.pbPernaE.Image = global::Forca_CSharp.Properties.Resources.Perna_esq;
            this.pbPernaE.Location = new System.Drawing.Point(462, 208);
            this.pbPernaE.Name = "pbPernaE";
            this.pbPernaE.Size = new System.Drawing.Size(45, 75);
            this.pbPernaE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPernaE.TabIndex = 22;
            this.pbPernaE.TabStop = false;
            this.pbPernaE.Visible = false;
            // 
            // pbPernaD
            // 
            this.pbPernaD.Image = global::Forca_CSharp.Properties.Resources.Perna_dir;
            this.pbPernaD.Location = new System.Drawing.Point(505, 208);
            this.pbPernaD.Name = "pbPernaD";
            this.pbPernaD.Size = new System.Drawing.Size(45, 75);
            this.pbPernaD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPernaD.TabIndex = 21;
            this.pbPernaD.TabStop = false;
            this.pbPernaD.Visible = false;
            // 
            // pbBracoE
            // 
            this.pbBracoE.Image = global::Forca_CSharp.Properties.Resources.braco_esq;
            this.pbBracoE.Location = new System.Drawing.Point(454, 176);
            this.pbBracoE.Name = "pbBracoE";
            this.pbBracoE.Size = new System.Drawing.Size(45, 36);
            this.pbBracoE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBracoE.TabIndex = 20;
            this.pbBracoE.TabStop = false;
            this.pbBracoE.Visible = false;
            // 
            // pbBracoD
            // 
            this.pbBracoD.Image = global::Forca_CSharp.Properties.Resources.braco_dir;
            this.pbBracoD.Location = new System.Drawing.Point(513, 176);
            this.pbBracoD.Name = "pbBracoD";
            this.pbBracoD.Size = new System.Drawing.Size(45, 36);
            this.pbBracoD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBracoD.TabIndex = 19;
            this.pbBracoD.TabStop = false;
            this.pbBracoD.Visible = false;
            // 
            // pbCorpo
            // 
            this.pbCorpo.Image = global::Forca_CSharp.Properties.Resources.corpo;
            this.pbCorpo.Location = new System.Drawing.Point(484, 176);
            this.pbCorpo.Name = "pbCorpo";
            this.pbCorpo.Size = new System.Drawing.Size(45, 36);
            this.pbCorpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCorpo.TabIndex = 18;
            this.pbCorpo.TabStop = false;
            this.pbCorpo.Visible = false;
            // 
            // pbCabeca
            // 
            this.pbCabeca.Image = global::Forca_CSharp.Properties.Resources.cabeca;
            this.pbCabeca.Location = new System.Drawing.Point(484, 138);
            this.pbCabeca.Name = "pbCabeca";
            this.pbCabeca.Size = new System.Drawing.Size(45, 36);
            this.pbCabeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCabeca.TabIndex = 17;
            this.pbCabeca.TabStop = false;
            this.pbCabeca.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forca_CSharp.Properties.Resources.forca;
            this.pictureBox1.Location = new System.Drawing.Point(393, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPernaE);
            this.Controls.Add(this.pbPernaD);
            this.Controls.Add(this.pbBracoE);
            this.Controls.Add(this.pbBracoD);
            this.Controls.Add(this.pbCorpo);
            this.Controls.Add(this.pbCabeca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtLetra);
            this.Controls.Add(this.btTenta);
            this.Controls.Add(this.btComeca);
            this.Controls.Add(this.tbPalavra);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbFaltam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTentadas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPalavra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Jogo da Forca";
            ((System.ComponentModel.ISupportInitialize)(this.pbPernaE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPernaD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBracoE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBracoD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPalavra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTentadas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbFaltam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.TextBox tbPalavra;
        private System.Windows.Forms.Button btComeca;
        private System.Windows.Forms.Button btTenta;
        private System.Windows.Forms.MaskedTextBox mtLetra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbCabeca;
        private System.Windows.Forms.PictureBox pbCorpo;
        private System.Windows.Forms.PictureBox pbBracoD;
        private System.Windows.Forms.PictureBox pbBracoE;
        private System.Windows.Forms.PictureBox pbPernaD;
        private System.Windows.Forms.PictureBox pbPernaE;
    }
}

