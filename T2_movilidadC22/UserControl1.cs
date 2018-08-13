using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //NEW crear carpeta y archivo para contener los datos de los usuarios a registrarse
            string carpeta = Application.StartupPath + @"\Informacion_de_usuarios";
            string archivo = @"\usuarios_registrados.txt";
            string crea = carpeta + archivo;
        }
    }
}
