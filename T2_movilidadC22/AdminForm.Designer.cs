namespace T2_movilidadC22
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.verUsersBt = new System.Windows.Forms.Button();
            this.verEncuestasBt = new System.Windows.Forms.Button();
            this.visualizarRichTxt = new System.Windows.Forms.RichTextBox();
            this.volverbt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué desea hacer?";
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::T2_movilidadC22.Properties.Resources.logos4__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // verUsersBt
            // 
            this.verUsersBt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verUsersBt.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.verUsersBt.Location = new System.Drawing.Point(20, 111);
            this.verUsersBt.Name = "verUsersBt";
            this.verUsersBt.Size = new System.Drawing.Size(178, 32);
            this.verUsersBt.TabIndex = 21;
            this.verUsersBt.Text = "Visualizar usuarios ingresados";
            this.verUsersBt.UseVisualStyleBackColor = true;
            this.verUsersBt.Click += new System.EventHandler(this.verUsersBt_Click);
            // 
            // verEncuestasBt
            // 
            this.verEncuestasBt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verEncuestasBt.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.verEncuestasBt.Location = new System.Drawing.Point(204, 111);
            this.verEncuestasBt.Name = "verEncuestasBt";
            this.verEncuestasBt.Size = new System.Drawing.Size(195, 32);
            this.verEncuestasBt.TabIndex = 22;
            this.verEncuestasBt.Text = "Visualizar encuestas diligenciadas";
            this.verEncuestasBt.UseVisualStyleBackColor = true;
            this.verEncuestasBt.Click += new System.EventHandler(this.verEncuestasBt_Click);
            // 
            // visualizarRichTxt
            // 
            this.visualizarRichTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visualizarRichTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.visualizarRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.visualizarRichTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizarRichTxt.Location = new System.Drawing.Point(20, 149);
            this.visualizarRichTxt.Name = "visualizarRichTxt";
            this.visualizarRichTxt.ReadOnly = true;
            this.visualizarRichTxt.Size = new System.Drawing.Size(555, 294);
            this.visualizarRichTxt.TabIndex = 23;
            this.visualizarRichTxt.Text = "";
            // 
            // volverbt
            // 
            this.volverbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volverbt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverbt.Location = new System.Drawing.Point(500, 462);
            this.volverbt.Name = "volverbt";
            this.volverbt.Size = new System.Drawing.Size(75, 23);
            this.volverbt.TabIndex = 24;
            this.volverbt.Text = "Volver";
            this.volverbt.UseVisualStyleBackColor = true;
            this.volverbt.Click += new System.EventHandler(this.volverbt_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(587, 497);
            this.Controls.Add(this.volverbt);
            this.Controls.Add(this.visualizarRichTxt);
            this.Controls.Add(this.verEncuestasBt);
            this.Controls.Add(this.verUsersBt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button verUsersBt;
        private System.Windows.Forms.Button verEncuestasBt;
        private System.Windows.Forms.RichTextBox visualizarRichTxt;
        private System.Windows.Forms.Button volverbt;
    }
}