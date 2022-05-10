
namespace WindowsFormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Clientes = new System.Windows.Forms.Button();
            this.Button_Vendas = new System.Windows.Forms.Button();
            this.Button_Produtos = new System.Windows.Forms.Button();
            this.Button_Voltar = new System.Windows.Forms.Button();
            this.DgvForm1 = new System.Windows.Forms.DataGridView();
            this.Button_Inserir = new System.Windows.Forms.Button();
            this.Button_Alterar = new System.Windows.Forms.Button();
            this.Button_Excluir = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.Button_Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvForm1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Clientes
            // 
            this.Button_Clientes.Location = new System.Drawing.Point(12, 12);
            this.Button_Clientes.Name = "Button_Clientes";
            this.Button_Clientes.Size = new System.Drawing.Size(75, 23);
            this.Button_Clientes.TabIndex = 2;
            this.Button_Clientes.Text = "Clientes";
            this.Button_Clientes.UseVisualStyleBackColor = true;
            this.Button_Clientes.Click += new System.EventHandler(this.Button_Clientes_Click);
            // 
            // Button_Vendas
            // 
            this.Button_Vendas.Location = new System.Drawing.Point(93, 12);
            this.Button_Vendas.Name = "Button_Vendas";
            this.Button_Vendas.Size = new System.Drawing.Size(75, 23);
            this.Button_Vendas.TabIndex = 3;
            this.Button_Vendas.Text = "Vendas";
            this.Button_Vendas.UseVisualStyleBackColor = true;
            this.Button_Vendas.Click += new System.EventHandler(this.Button_Vendas_Click_1);
            // 
            // Button_Produtos
            // 
            this.Button_Produtos.Location = new System.Drawing.Point(174, 12);
            this.Button_Produtos.Name = "Button_Produtos";
            this.Button_Produtos.Size = new System.Drawing.Size(75, 23);
            this.Button_Produtos.TabIndex = 4;
            this.Button_Produtos.Text = "Produtos";
            this.Button_Produtos.UseVisualStyleBackColor = true;
            this.Button_Produtos.Click += new System.EventHandler(this.Button_Produtos_Click_1);
            // 
            // Button_Voltar
            // 
            this.Button_Voltar.Location = new System.Drawing.Point(12, 415);
            this.Button_Voltar.Name = "Button_Voltar";
            this.Button_Voltar.Size = new System.Drawing.Size(75, 23);
            this.Button_Voltar.TabIndex = 7;
            this.Button_Voltar.Text = "Voltar";
            this.Button_Voltar.UseVisualStyleBackColor = true;
            this.Button_Voltar.Click += new System.EventHandler(this.Button_Voltar_Click);
            // 
            // DgvForm1
            // 
            this.DgvForm1.AllowUserToAddRows = false;
            this.DgvForm1.AllowUserToDeleteRows = false;
            this.DgvForm1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvForm1.Location = new System.Drawing.Point(12, 119);
            this.DgvForm1.Name = "DgvForm1";
            this.DgvForm1.ReadOnly = true;
            this.DgvForm1.RowTemplate.Height = 25;
            this.DgvForm1.Size = new System.Drawing.Size(561, 290);
            this.DgvForm1.TabIndex = 8;
            this.DgvForm1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvForm1_RowEnter);
            // 
            // Button_Inserir
            // 
            this.Button_Inserir.Location = new System.Drawing.Point(12, 89);
            this.Button_Inserir.Name = "Button_Inserir";
            this.Button_Inserir.Size = new System.Drawing.Size(75, 23);
            this.Button_Inserir.TabIndex = 9;
            this.Button_Inserir.Text = "Inserir";
            this.Button_Inserir.UseVisualStyleBackColor = true;
            this.Button_Inserir.Click += new System.EventHandler(this.Button_Inserir_Click_1);
            // 
            // Button_Alterar
            // 
            this.Button_Alterar.Location = new System.Drawing.Point(93, 89);
            this.Button_Alterar.Name = "Button_Alterar";
            this.Button_Alterar.Size = new System.Drawing.Size(75, 23);
            this.Button_Alterar.TabIndex = 10;
            this.Button_Alterar.Text = "Alterar";
            this.Button_Alterar.UseVisualStyleBackColor = true;
            this.Button_Alterar.Click += new System.EventHandler(this.Button_Alterar_Click);
            // 
            // Button_Excluir
            // 
            this.Button_Excluir.Location = new System.Drawing.Point(498, 12);
            this.Button_Excluir.Name = "Button_Excluir";
            this.Button_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Button_Excluir.TabIndex = 11;
            this.Button_Excluir.Text = "Excluir";
            this.Button_Excluir.UseVisualStyleBackColor = true;
            this.Button_Excluir.Click += new System.EventHandler(this.Button_Excluir_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(255, 89);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(237, 23);
            this.TxtPesquisa.TabIndex = 12;
            // 
            // Button_Pesquisar
            // 
            this.Button_Pesquisar.Location = new System.Drawing.Point(498, 89);
            this.Button_Pesquisar.Name = "Button_Pesquisar";
            this.Button_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.Button_Pesquisar.TabIndex = 13;
            this.Button_Pesquisar.Text = "Pesquisar";
            this.Button_Pesquisar.UseVisualStyleBackColor = true;
            this.Button_Pesquisar.Click += new System.EventHandler(this.Button_Pesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.Button_Pesquisar);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.Button_Excluir);
            this.Controls.Add(this.Button_Alterar);
            this.Controls.Add(this.Button_Inserir);
            this.Controls.Add(this.DgvForm1);
            this.Controls.Add(this.Button_Voltar);
            this.Controls.Add(this.Button_Produtos);
            this.Controls.Add(this.Button_Vendas);
            this.Controls.Add(this.Button_Clientes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvForm1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Clientes;
        private System.Windows.Forms.Button Button_Vendas;
        private System.Windows.Forms.Button Button_Produtos;
        private System.Windows.Forms.Button Button_Voltar;
        private System.Windows.Forms.DataGridView DgvForm1;
        private System.Windows.Forms.Button Button_Inserir;
        private System.Windows.Forms.Button Button_Alterar;
        private System.Windows.Forms.Button Button_Excluir;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Button Button_Pesquisar;
    }
}

