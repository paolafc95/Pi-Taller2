namespace T2_movilidadC22
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.userlabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.passtextBox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(32, 39);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(56, 16);
            this.userlabel.TabIndex = 0;
            this.userlabel.Text = "Usuario";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(32, 94);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(83, 16);
            this.passlabel.TabIndex = 1;
            this.passlabel.Text = "Contraseña";
            // 
            // usertextBox
            // 
            this.usertextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertextBox.Location = new System.Drawing.Point(131, 39);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.Size = new System.Drawing.Size(154, 23);
            this.usertextBox.TabIndex = 2;
            // 
            // passtextBox
            // 
            this.passtextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtextBox.Location = new System.Drawing.Point(131, 94);
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(154, 23);
            this.passtextBox.TabIndex = 3;
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(131, 151);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(84, 25);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Ingresar";
            this.loginbutton.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passtextBox);
            this.Controls.Add(this.usertextBox);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.userlabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(363, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.TextBox passtextBox;
        private System.Windows.Forms.Button loginbutton;
    }
}
