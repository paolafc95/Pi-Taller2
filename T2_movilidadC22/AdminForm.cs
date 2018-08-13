using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_movilidadC22
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void verUsersBt_Click(object sender, EventArgs e)
        {
            string carpeta = Application.StartupPath + @"\Informacion_de_usuarios";
            string archivo = @"\usuarios_registrados.txt";
            string ubicacion = carpeta + archivo;
            StreamReader informacion = new StreamReader(ubicacion);
            string texto = informacion.ReadToEnd();
            visualizarRichTxt.Text = texto;
            informacion.Close();
        }

        private void verEncuestasBt_Click(object sender, EventArgs e)
        {
            string carpeta = Application.StartupPath + @"\Informacion_de_usuarios";
            string archivo = @"\encuesta.txt";
            string ubicacion = carpeta + archivo;
            StreamReader informacion = new StreamReader(ubicacion);
            string texto = informacion.ReadToEnd();
            visualizarRichTxt.Text = texto;
            informacion.Close();

        }

        private void volverbt_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        
        }
    }
}
