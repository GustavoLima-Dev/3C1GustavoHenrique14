namespace _3c1gustavoHenrique14
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
            this.label_id = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_view = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(96, 72);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(16, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Id";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(96, 172);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_modelo.TabIndex = 1;
            this.lbl_modelo.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            // 
            // dgv_view
            // 
            this.dgv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_view.Location = new System.Drawing.Point(270, 72);
            this.dgv_view.Name = "dgv_view";
            this.dgv_view.Size = new System.Drawing.Size(483, 274);
            this.dgv_view.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(99, 104);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 4;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(99, 200);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 5;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(99, 320);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(100, 20);
            this.txt_preco.TabIndex = 6;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(270, 380);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(88, 34);
            this.btn_inserir.TabIndex = 7;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(530, 380);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(88, 34);
            this.btn_atualizar.TabIndex = 9;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(406, 380);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(88, 34);
            this.btn_deletar.TabIndex = 10;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(665, 380);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(88, 34);
            this.btn_listar.TabIndex = 11;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dgv_view);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.label_id);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_view;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_listar;
    }
}

