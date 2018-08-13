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
    public partial class PollForm : Form
    {
        public PollForm()
        {
            InitializeComponent();
                      
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tiempoVtxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EnviarButton_Click(object sender, EventArgs e)
        {
            string carpeta = Application.StartupPath + @"\Informacion_de_usuarios";
            string archivoEncuesta = @"\encuesta.txt";
            string creaE = carpeta + archivoEncuesta;

            try
            {
                if (File.Exists(creaE))
                {
                    MessageBox.Show("Archivo existente");
                }
                else
                {
                    MessageBox.Show("Creando archivo");
                    Directory.CreateDirectory(carpeta);
                    using (File.Create(creaE)) ;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            String dificultades = dificultadTxtBox.Text;
            String llegaTiempo = aTiempotxtbx.Text;
            String tiempoTarde = tiempoTardeTxtbx.Text;
            String carrera = carreraTxtBx.Text;
            String tiempoViaje = tiempoVtxtbx.Text;
            String acuerdo = acuerdoTxtbx.Text;
            String medioTrans = medioTranstxtBx.Text;
            String jornada = jornadatextBox.Text;
            String porque = porqueTxtbx.Text;


            string[] infoEncuesta = { "\n" + dificultades +";"+ llegaTiempo+" llegó a tiempo"+";" + tiempoTarde + ";" + carrera +";"+tiempoViaje + ";"+ acuerdo +" estoy de acuerdo"+ ";"+ medioTrans + ";"+jornada + ";"+porque +";" };

            File.AppendAllLines(creaE, infoEncuesta);    
        }

        private void PollForm_Load(object sender, EventArgs e)
        {

        }

        
        
    }
}
