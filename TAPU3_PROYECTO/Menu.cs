using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPU3_PROYECTO
{
    public partial class FormMenu : Form
    {
        //id del alumno elegido 
        int indexx = Form1.index;
        public static int semestre;
        public static String materiaExamen = "";
        private String nombre1;

        private static String Diego = "http://192.168.1.70/my_sge/infoE.php";
        private static String Marco = "http://192.168.1.10/my_sge/infoE.php";

        private static String DiegoP = "http://192.168.1.70/my_sge/verCalif.php";
        private static String MarcoP = "http://192.168.1.10/my_sge/verCalif.php";

        //cambiar valor segun el usuario 
        String ws = Marco;
        String wsP = MarcoP;

        public FormMenu()
        {
            InitializeComponent();
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            //Carga en el formulario información del alumno
            HttpClient client = new HttpClient();
            String content = await client.GetStringAsync(ws + "/?id="+indexx);

            try
            {
                JObject jsonObject = JObject.Parse(content);
                JArray jOutput = (JArray)jsonObject.GetValue("output");
                Console.WriteLine(jOutput.ToString());
                JObject jIndex = (JObject)jOutput[0];

                nombre1 = (String)jIndex.GetValue("nombre");
                semestre = (int)jIndex.GetValue("semestre");
                Console.WriteLine(semestre);

                labelNombre.Text +=": "+nombre1;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex);
                MessageBox.Show("Error en la lectura");
            }


            //Se cargan las materias para los examenes
            HttpClient ma = new HttpClient();
            String materia = await ma.GetStringAsync(wsP + "?usr=" + Form1.index);
            Console.WriteLine(materia);

            //nombre_materia y calificacion 
            try
            {
                JObject jsonObject = JObject.Parse(materia);
                JArray jOutput = (JArray)jsonObject.GetValue("output");

                for (int i = 0; i < jOutput.Count; i++)
                {
                    JObject jmateria = (JObject)jOutput[i];
                    comboBox1.Items.Add(jmateria.GetValue("nombre_materia").ToString());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(e);
                MessageBox.Show("Error al consultar");
                throw;
            }
        }

        private void btnCali_Click(object sender, EventArgs e)
        {
            new Calificaciones().Show(); //Se abre el formulario de calificaciones
        }

        private void btnReticula_Click(object sender, EventArgs e)
        {
            new Reticula().Show(); //Se abre el formulario de reticula
        }

     

        private void btnHorario_Click(object sender, EventArgs e)
        {
            new Horario().Show(); //Se abre el formulario de horario
        }

        private void btnExamen_Click(object sender, EventArgs e)
        {
            if (!comboBox1.SelectedIndex.ToString().Equals("-1"))
            {
                materiaExamen = comboBox1.SelectedItem.ToString();
                new Examenes().Show();//Se abre el formulario de examenes
            }
            else
            {
                MessageBox.Show("Selecciona una materia para hacer el examen");
            }
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            new Datos().Show();
        }
    }
}
