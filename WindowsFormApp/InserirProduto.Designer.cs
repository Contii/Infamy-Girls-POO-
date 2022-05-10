
namespace WindowsFormApp
{
    partial class InserirProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirProduto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RadioButtonSuperior = new System.Windows.Forms.RadioButton();
            this.RadioButtonInferior = new System.Windows.Forms.RadioButton();
            this.RadioButtonSuperiorInferior = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtCategoria = new System.Windows.Forms.ComboBox();
            this.TxtCor = new System.Windows.Forms.TextBox();
            this.TxtTamanho = new System.Windows.Forms.ComboBox();
            this.TxtBustoMax = new System.Windows.Forms.TextBox();
            this.TxtBustoMin = new System.Windows.Forms.TextBox();
            this.TxtSubBustoMax = new System.Windows.Forms.TextBox();
            this.TxtSubBustoMin = new System.Windows.Forms.TextBox();
            this.TxtCinturaMax = new System.Windows.Forms.TextBox();
            this.TxtCinturaMin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.Location = new System.Drawing.Point(298, 303);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCadastrar.TabIndex = 32;
            this.ButtonCadastrar.Text = "Cadastrar";
            this.ButtonCadastrar.UseVisualStyleBackColor = true;
            this.ButtonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tamanho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Cor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Busto Máximo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Busto Mínimo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "SubBusto Máximo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "SubBusto Mínimo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Cintura Máxima:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 43;
            this.label11.Text = "Cintura Mínima:";
            // 
            // RadioButtonSuperior
            // 
            this.RadioButtonSuperior.AutoSize = true;
            this.RadioButtonSuperior.Location = new System.Drawing.Point(10, 176);
            this.RadioButtonSuperior.Name = "RadioButtonSuperior";
            this.RadioButtonSuperior.Size = new System.Drawing.Size(69, 19);
            this.RadioButtonSuperior.TabIndex = 44;
            this.RadioButtonSuperior.TabStop = true;
            this.RadioButtonSuperior.Text = "Superior";
            this.RadioButtonSuperior.UseVisualStyleBackColor = true;
            // 
            // RadioButtonInferior
            // 
            this.RadioButtonInferior.AutoSize = true;
            this.RadioButtonInferior.Location = new System.Drawing.Point(10, 203);
            this.RadioButtonInferior.Name = "RadioButtonInferior";
            this.RadioButtonInferior.Size = new System.Drawing.Size(63, 19);
            this.RadioButtonInferior.TabIndex = 45;
            this.RadioButtonInferior.TabStop = true;
            this.RadioButtonInferior.Text = "Inferior";
            this.RadioButtonInferior.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSuperiorInferior
            // 
            this.RadioButtonSuperiorInferior.AutoSize = true;
            this.RadioButtonSuperiorInferior.Location = new System.Drawing.Point(10, 151);
            this.RadioButtonSuperiorInferior.Name = "RadioButtonSuperiorInferior";
            this.RadioButtonSuperiorInferior.Size = new System.Drawing.Size(119, 19);
            this.RadioButtonSuperiorInferior.TabIndex = 46;
            this.RadioButtonSuperiorInferior.TabStop = true;
            this.RadioButtonSuperiorInferior.Text = "Superior e Inferior";
            this.RadioButtonSuperiorInferior.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(10, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 21);
            this.label12.TabIndex = 47;
            this.label12.Text = "Qual o tipo da peça?";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(59, 12);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(118, 23);
            this.TxtNome.TabIndex = 48;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(273, 41);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 23);
            this.TxtValor.TabIndex = 49;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.FormattingEnabled = true;
            this.TxtCategoria.Location = new System.Drawing.Point(77, 41);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(100, 23);
            this.TxtCategoria.TabIndex = 51;
            // 
            // TxtCor
            // 
            this.TxtCor.Location = new System.Drawing.Point(273, 12);
            this.TxtCor.Name = "TxtCor";
            this.TxtCor.Size = new System.Drawing.Size(100, 23);
            this.TxtCor.TabIndex = 52;
            // 
            // TxtTamanho
            // 
            this.TxtTamanho.FormattingEnabled = true;
            this.TxtTamanho.Items.AddRange(new object[] {
            "P",
            "M",
            "G",
            "GG"});
            this.TxtTamanho.Location = new System.Drawing.Point(77, 70);
            this.TxtTamanho.Name = "TxtTamanho";
            this.TxtTamanho.Size = new System.Drawing.Size(47, 23);
            this.TxtTamanho.TabIndex = 54;
            // 
            // TxtBustoMax
            // 
            this.TxtBustoMax.Location = new System.Drawing.Point(325, 118);
            this.TxtBustoMax.Name = "TxtBustoMax";
            this.TxtBustoMax.Size = new System.Drawing.Size(48, 23);
            this.TxtBustoMax.TabIndex = 55;
            // 
            // TxtBustoMin
            // 
            this.TxtBustoMin.Location = new System.Drawing.Point(325, 147);
            this.TxtBustoMin.Name = "TxtBustoMin";
            this.TxtBustoMin.Size = new System.Drawing.Size(48, 23);
            this.TxtBustoMin.TabIndex = 56;
            // 
            // TxtSubBustoMax
            // 
            this.TxtSubBustoMax.Location = new System.Drawing.Point(325, 176);
            this.TxtSubBustoMax.Name = "TxtSubBustoMax";
            this.TxtSubBustoMax.Size = new System.Drawing.Size(48, 23);
            this.TxtSubBustoMax.TabIndex = 57;
            // 
            // TxtSubBustoMin
            // 
            this.TxtSubBustoMin.Location = new System.Drawing.Point(325, 205);
            this.TxtSubBustoMin.Name = "TxtSubBustoMin";
            this.TxtSubBustoMin.Size = new System.Drawing.Size(48, 23);
            this.TxtSubBustoMin.TabIndex = 58;
            // 
            // TxtCinturaMax
            // 
            this.TxtCinturaMax.Location = new System.Drawing.Point(325, 234);
            this.TxtCinturaMax.Name = "TxtCinturaMax";
            this.TxtCinturaMax.Size = new System.Drawing.Size(48, 23);
            this.TxtCinturaMax.TabIndex = 59;
            // 
            // TxtCinturaMin
            // 
            this.TxtCinturaMin.Location = new System.Drawing.Point(325, 263);
            this.TxtCinturaMin.Name = "TxtCinturaMin";
            this.TxtCinturaMin.Size = new System.Drawing.Size(48, 23);
            this.TxtCinturaMin.TabIndex = 60;
            // 
            // InserirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 338);
            this.Controls.Add(this.TxtCinturaMin);
            this.Controls.Add(this.TxtCinturaMax);
            this.Controls.Add(this.TxtSubBustoMin);
            this.Controls.Add(this.TxtSubBustoMax);
            this.Controls.Add(this.TxtBustoMin);
            this.Controls.Add(this.TxtBustoMax);
            this.Controls.Add(this.TxtTamanho);
            this.Controls.Add(this.TxtCor);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RadioButtonSuperiorInferior);
            this.Controls.Add(this.RadioButtonInferior);
            this.Controls.Add(this.RadioButtonSuperior);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InserirProduto";
            this.Text = "InserirProduto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton RadioButtonSuperior;
        private System.Windows.Forms.RadioButton RadioButtonInferior;
        private System.Windows.Forms.RadioButton RadioButtonSuperiorInferior;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.ComboBox TxtCategoria;
        private System.Windows.Forms.TextBox TxtCor;
        private System.Windows.Forms.ComboBox TxtTamanho;
        private System.Windows.Forms.TextBox TxtBustoMax;
        private System.Windows.Forms.TextBox TxtBustoMin;
        private System.Windows.Forms.TextBox TxtSubBustoMax;
        private System.Windows.Forms.TextBox TxtSubBustoMin;
        private System.Windows.Forms.TextBox TxtCinturaMax;
        private System.Windows.Forms.TextBox TxtCinturaMin;
    }
}