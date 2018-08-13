using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace T2_movilidadC22
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            PollForm encuesta = new PollForm();
            encuesta.Show();

            //NEW crear carpeta y archivo para contener los datos de los usuarios a registrarse
            string carpeta = Application.StartupPath + @"\Informacion_de_usuarios";
            string archivo = @"\usuarios_registrados.txt";
            string crea = carpeta + archivo;

            try
            {
                if (File.Exists(crea))
                {
                    MessageBox.Show("Archivo existente");
                }
                else
                {
                    MessageBox.Show("Creando archivo");
                    Directory.CreateDirectory(carpeta);
                    using (File.Create(crea));
                                      
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            String user = usertextBox.Text;
            String password = passtextBox.Text;
            string[] infoUsuario = { "\n" + user + ";" +password+";"};
            File.AppendAllLines(crea, infoUsuario);
        }
    }
}
