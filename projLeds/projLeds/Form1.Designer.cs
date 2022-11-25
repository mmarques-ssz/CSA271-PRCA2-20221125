namespace projLeds
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
            this.picLampada = new System.Windows.Forms.PictureBox();
            this.btnAcender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLampada)).BeginInit();
            this.SuspendLayout();
            // 
            // picLampada
            // 
            this.picLampada.Location = new System.Drawing.Point(109, 24);
            this.picLampada.Name = "picLampada";
            this.picLampada.Size = new System.Drawing.Size(100, 106);
            this.picLampada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLampada.TabIndex = 0;
            this.picLampada.TabStop = false;
            // 
            // btnAcender
            // 
            this.btnAcender.Location = new System.Drawing.Point(125, 147);
            this.btnAcender.Name = "btnAcender";
            this.btnAcender.Size = new System.Drawing.Size(75, 23);
            this.btnAcender.TabIndex = 1;
            this.btnAcender.Text = "Acender";
            this.btnAcender.UseVisualStyleBackColor = true;
            this.btnAcender.Click += new System.EventHandler(this.acener);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(125, 188);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.apagar);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(125, 241);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOnOff.TabIndex = 3;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.onoff);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 304);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAcender);
            this.Controls.Add(this.picLampada);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLampada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLampada;
        private System.Windows.Forms.Button btnAcender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnOnOff;
    }
}

