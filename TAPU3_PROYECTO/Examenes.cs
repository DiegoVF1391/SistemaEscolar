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
    public partial class Examenes : Form
    {
        int semestre = FormMenu.semestre;
        String materia = FormMenu.materiaExamen;

        //guardar semestre, respuesta y carrera
        private String car, inciso, respuestaCorrecta;
        private int cont = 0, numRespuestas = 0;

        private String materiaCalif;

        JObject jIndex;
        JArray jOutput;

        private static String Diego = "http://192.168.1.70/my_sge/preguntas.php";
        private static String Marco = "http://192.168.1.10/my_sge/preguntas.php";

        String ws = Diego;
        public Examenes()
        {
            InitializeComponent();
        }

        private async void Examenes_LoadAsync(object sender, EventArgs e)
        {
            labelMateria.Text = materia;

            HttpClient client = new HttpClient();
            String content = await client.GetStringAsync(ws + "?materia=" + materia 
                + "&semestre=" + semestre);
            try
            {
                JObject jsonObject = JObject.Parse(content);
                jOutput = (JArray)jsonObject.GetValue("output");
                Console.WriteLine(jOutput.ToString());
                jIndex = (JObject)jOutput[cont];

                if (jIndex.ContainsKey("pregunta"))
                {
                    comboBox1.Items.Clear();
                    label1.Text += (String)jIndex.GetValue("pregunta"); 
                }
                //labelNombre.Text += ": " + nombre1;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex);
                MessageBox.Show("Error en la lectura");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            cont++;
            pregunta();
            /*if (!comboBox1.SelectedIndex.ToString().Equals("-1"))
            {
                if (comboBox1.SelectedItem.Equals(respuestaCorrecta))
                {
                    numRespuestas += 10;
                }
                cont++;
                pregunta();
            }
            else
            {
                MessageBox.Show("Selecciona una respuesta");
            }*/
        }

        private void pregunta()
        {
            //Sea
            if (cont < 10)
            {
                label1.Text = "";
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                jIndex = (JObject)jOutput[cont];
                if (jIndex.ContainsKey("pregunta"))
                {

                    comboBox1.Items.Clear();
                    label1.Text = (cont+1) + ".-Pregunta ";
                    label1.Text += (String)jIndex.GetValue("pregunta");
                }
            }
            else
            {
                MessageBox.Show("Usted obtuvo " + numRespuestas);
                //calificarExamen(numRespuestas);
                this.Dispose();
            }
        }
    }
}
