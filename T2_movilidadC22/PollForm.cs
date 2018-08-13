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
                    MessageBox.Show("Encuesta enviada");                   
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


            string[] infoEncuesta = { "\n" + "Dificultad: "+ dificultades +";"+ llegaTiempo+" llegó a tiempo"+";" + "Tiempo tarde:"+tiempoTarde + " minutos"+ ";" + "Programa: "+carrera +";"+ "Tiempo de viaje:"+tiempoViaje + ";"+ acuerdo +" estoy de acuerdo"+ ";"+"Medio transp. "+ medioTrans + ";"+ "Jornada "+jornada + ";"+porque +";" };

            File.AppendAllLines(creaE, infoEncuesta);
            this.Close(); 
        }

        private void PollForm_Load(object sender, EventArgs e)
        {

        }

        
        
    }
}
