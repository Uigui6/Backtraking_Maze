namespace Labirinto
{
    partial class FrmCaminhos
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
            this.btn_OFD = new System.Windows.Forms.Button();
            this.btn_Encontrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dgvLabirinto = new System.Windows.Forms.DataGridView();
            this.dgvCaminhos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OFD
            // 
            this.btn_OFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OFD.Location = new System.Drawing.Point(763, 12);
            this.btn_OFD.Name = "btn_OFD";
            this.btn_OFD.Size = new System.Drawing.Size(80, 40);
            this.btn_OFD.TabIndex = 0;
            this.btn_OFD.Text = "Abrir arquivo";
            this.btn_OFD.UseVisualStyleBackColor = true;
            this.btn_OFD.Click += new System.EventHandler(this.Btn_OFD_Click);
            // 
            // btn_Encontrar
            // 
            this.btn_Encontrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encontrar.Location = new System.Drawing.Point(849, 12);
            this.btn_Encontrar.Name = "btn_Encontrar";
            this.btn_Encontrar.Size = new System.Drawing.Size(80, 40);
            this.btn_Encontrar.TabIndex = 1;
            this.btn_Encontrar.Text = "Encontrar caminhos";
            this.btn_Encontrar.UseVisualStyleBackColor = true;
            this.btn_Encontrar.Click += new System.EventHandler(this.Btn_Encontrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Labirinto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caminhos encontrados";
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // dgvLabirinto
            // 
            this.dgvLabirinto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLabirinto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabirinto.Location = new System.Drawing.Point(12, 55);
            this.dgvLabirinto.Name = "dgvLabirinto";
            this.dgvLabirinto.Size = new System.Drawing.Size(366, 420);
            this.dgvLabirinto.TabIndex = 0;
            // 
            // dgvCaminhos
            // 
            this.dgvCaminhos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaminhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhos.Location = new System.Drawing.Point(395, 55);
            this.dgvCaminhos.Name = "dgvCaminhos";
            this.dgvCaminhos.Size = new System.Drawing.Size(534, 420);
            this.dgvCaminhos.TabIndex = 4;
            // 
            // FrmCaminhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 487);
            this.Controls.Add(this.dgvCaminhos);
            this.Controls.Add(this.dgvLabirinto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Encontrar);
            this.Controls.Add(this.btn_OFD);
            this.Name = "FrmCaminhos";
            this.Text = "Caminhos em Labirinto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OFD;
        private System.Windows.Forms.Button btn_Encontrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.DataGridView dgvLabirinto;
        private System.Windows.Forms.DataGridView dgvCaminhos;
    }
}

