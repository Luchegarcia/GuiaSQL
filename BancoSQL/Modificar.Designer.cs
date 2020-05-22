namespace BancoSQL
{
    partial class Modificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ConceitoBox = new System.Windows.Forms.ComboBox();
            this.Imagem = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SintaxeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DefinicaoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConceitoLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Alterar Imagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConceitoBox
            // 
            this.ConceitoBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConceitoBox.FormattingEnabled = true;
            this.ConceitoBox.Items.AddRange(new object[] {
            "Agregações",
            "Classificações",
            "Constraints",
            "Criar um Database / banco",
            "Funções Matemáticas",
            "Instruções de Lingugem",
            "Logica",
            "Operadores Artimeticos",
            "Operadores Logicos",
            "Tabela",
            "Tipos de dados",
            "Outros"});
            this.ConceitoBox.Location = new System.Drawing.Point(252, 21);
            this.ConceitoBox.Name = "ConceitoBox";
            this.ConceitoBox.Size = new System.Drawing.Size(199, 24);
            this.ConceitoBox.TabIndex = 17;
            // 
            // Imagem
            // 
            this.Imagem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Imagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Imagem.Location = new System.Drawing.Point(61, 288);
            this.Imagem.Name = "Imagem";
            this.Imagem.Size = new System.Drawing.Size(679, 244);
            this.Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagem.TabIndex = 16;
            this.Imagem.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Exemplos";
            // 
            // SintaxeBox
            // 
            this.SintaxeBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SintaxeBox.Location = new System.Drawing.Point(61, 199);
            this.SintaxeBox.Name = "SintaxeBox";
            this.SintaxeBox.Size = new System.Drawing.Size(725, 23);
            this.SintaxeBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sintaxe";
            // 
            // DefinicaoBox
            // 
            this.DefinicaoBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefinicaoBox.Location = new System.Drawing.Point(62, 93);
            this.DefinicaoBox.Multiline = true;
            this.DefinicaoBox.Name = "DefinicaoBox";
            this.DefinicaoBox.Size = new System.Drawing.Size(612, 65);
            this.DefinicaoBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Definição";
            // 
            // ConceitoLabel
            // 
            this.ConceitoLabel.AutoSize = true;
            this.ConceitoLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConceitoLabel.Location = new System.Drawing.Point(58, 21);
            this.ConceitoLabel.Name = "ConceitoLabel";
            this.ConceitoLabel.Size = new System.Drawing.Size(198, 23);
            this.ConceitoLabel.TabIndex = 10;
            this.ConceitoLabel.Text = "Tipo de Conceito:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(785, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 65);
            this.button2.TabIndex = 19;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConceitoBox);
            this.Controls.Add(this.Imagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SintaxeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DefinicaoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConceitoLabel);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ConceitoLabel;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox ConceitoBox;
        public System.Windows.Forms.PictureBox Imagem;
        public System.Windows.Forms.TextBox SintaxeBox;
        public System.Windows.Forms.TextBox DefinicaoBox;
        public System.Windows.Forms.Label label1;
    }
}