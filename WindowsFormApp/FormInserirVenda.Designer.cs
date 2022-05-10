
namespace WindowsFormApp
{
    partial class FormInserirVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInserirVenda));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvVenda = new System.Windows.Forms.DataGridView();
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.ButtonInserirItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Location = new System.Drawing.Point(12, 303);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelar.TabIndex = 30;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.Location = new System.Drawing.Point(382, 303);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCadastrar.TabIndex = 31;
            this.ButtonCadastrar.Text = "Cadastrar";
            this.ButtonCadastrar.UseVisualStyleBackColor = true;
            this.ButtonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(338, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total:";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTotal.Location = new System.Drawing.Point(389, 272);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(68, 21);
            this.LabelTotal.TabIndex = 33;
            this.LabelTotal.Text = "R$00,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Cliente:";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(64, 12);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(259, 23);
            this.TxtCliente.TabIndex = 35;
            // 
            // TxtProduto
            // 
            this.TxtProduto.Location = new System.Drawing.Point(64, 41);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(107, 23);
            this.TxtProduto.TabIndex = 36;
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(256, 41);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(67, 23);
            this.TxtQuantidade.TabIndex = 37;
            this.TxtQuantidade.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Quantidade:";
            // 
            // DgvVenda
            // 
            this.DgvVenda.AllowUserToAddRows = false;
            this.DgvVenda.AllowUserToDeleteRows = false;
            this.DgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVenda.Location = new System.Drawing.Point(5, 70);
            this.DgvVenda.Name = "DgvVenda";
            this.DgvVenda.ReadOnly = true;
            this.DgvVenda.RowTemplate.Height = 25;
            this.DgvVenda.Size = new System.Drawing.Size(452, 199);
            this.DgvVenda.TabIndex = 40;
            this.DgvVenda.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVenda_RowEnter);
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.Location = new System.Drawing.Point(382, 11);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.ButtonBuscar.TabIndex = 41;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.UseVisualStyleBackColor = true;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // ButtonInserirItem
            // 
            this.ButtonInserirItem.Location = new System.Drawing.Point(382, 41);
            this.ButtonInserirItem.Name = "ButtonInserirItem";
            this.ButtonInserirItem.Size = new System.Drawing.Size(75, 23);
            this.ButtonInserirItem.TabIndex = 42;
            this.ButtonInserirItem.Text = "Inserir Item";
            this.ButtonInserirItem.UseVisualStyleBackColor = true;
            this.ButtonInserirItem.Click += new System.EventHandler(this.ButtonInserirItem_Click);
            // 
            // FormInserirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 338);
            this.Controls.Add(this.ButtonInserirItem);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.DgvVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.TxtProduto);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormInserirVenda";
            this.Text = "FormInserirVenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.Button ButtonCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvVenda;
        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.Button ButtonInserirItem;
    }
}