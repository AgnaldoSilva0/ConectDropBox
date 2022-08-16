namespace ConectDropBox
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
            this.listLocal = new System.Windows.Forms.ListBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.btUpload = new System.Windows.Forms.Button();
            this.btDowload = new System.Windows.Forms.Button();
            this.listDropBox = new System.Windows.Forms.ListBox();
            this.lbLocal = new System.Windows.Forms.Label();
            this.lbDropBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listLocal
            // 
            this.listLocal.FormattingEnabled = true;
            this.listLocal.Location = new System.Drawing.Point(12, 133);
            this.listLocal.Name = "listLocal";
            this.listLocal.Size = new System.Drawing.Size(269, 199);
            this.listLocal.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(13, 23);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(13, 46);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email:";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(13, 69);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(27, 13);
            this.lbPais.TabIndex = 3;
            this.lbPais.Text = "Pais";
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(105, 338);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(75, 23);
            this.btUpload.TabIndex = 4;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btDowload
            // 
            this.btDowload.Location = new System.Drawing.Point(526, 338);
            this.btDowload.Name = "btDowload";
            this.btDowload.Size = new System.Drawing.Size(75, 23);
            this.btDowload.TabIndex = 6;
            this.btDowload.Text = "Download";
            this.btDowload.UseVisualStyleBackColor = true;
            this.btDowload.Click += new System.EventHandler(this.btDowload_Click);
            // 
            // listDropBox
            // 
            this.listDropBox.FormattingEnabled = true;
            this.listDropBox.Location = new System.Drawing.Point(422, 133);
            this.listDropBox.Name = "listDropBox";
            this.listDropBox.Size = new System.Drawing.Size(269, 199);
            this.listDropBox.TabIndex = 5;
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.Location = new System.Drawing.Point(12, 117);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(203, 13);
            this.lbLocal.TabIndex = 7;
            this.lbLocal.Text = "C:\\Users\\agnal\\Desktop\\TesteDropBox\\";
            // 
            // lbDropBox
            // 
            this.lbDropBox.AutoSize = true;
            this.lbDropBox.Location = new System.Drawing.Point(419, 117);
            this.lbDropBox.Name = "lbDropBox";
            this.lbDropBox.Size = new System.Drawing.Size(55, 13);
            this.lbDropBox.TabIndex = 8;
            this.lbDropBox.Text = "/AgnSoft/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 369);
            this.Controls.Add(this.lbDropBox);
            this.Controls.Add(this.lbLocal);
            this.Controls.Add(this.btDowload);
            this.Controls.Add(this.listDropBox);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.listLocal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLocal;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button btDowload;
        private System.Windows.Forms.ListBox listDropBox;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.Label lbDropBox;
    }
}

