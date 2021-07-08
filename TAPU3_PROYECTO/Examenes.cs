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
        private String car, inciso;
        private int cont = 0, numRespuestas = 0, idP=0, cont2 = 0;
        private bool respuestaCorrecta = false;

        private String materiaCalif;

        JObject jIndex;
        JArray jOutput;

        JObject jIndex2;
        JArray jOutput2;

        private static String Diego = "http://192.168.1.70/my_sge/preguntas.php";
        private static String Marco = "http://192.168.1.10/my_sge/preguntas.php";

        private static String Diegor = "http://192.168.1.70/my_sge/pyr.php";
        private static String Marcor = "http://192.168.1.10/my_sge/pyr.php";

        String ws = Marco;
        String wsr = Marcor;
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
                    idP = (int)jIndex.GetValue("id");

                }
                //labelNombre.Text += ": " + nombre1;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex);
                MessageBox.Show("Error en la lectura");
            }

            //MessageBox.Show(idP.ToString());
            //cargar respuestas 
            HttpClient client2 = new HttpClient();
            String respuestas = await client2.GetStringAsync(wsr + "?materia=" + materia
                + "&semestre=" + semestre + "&idPregunta=" + idP);
            try
            {
                JObject jsonObject2 = JObject.Parse(respuestas);
                jOutput2 = (JArray)jsonObject2.GetValue("output");
                Console.WriteLine(jOutput2.ToString());
                jIndex2 = (JObject)jOutput2[cont2];

                if (jIndex2.ContainsKey("respuesta"))
                {
                    //comboBox1.Items.Clear();

                    MessageBox.Show(jIndex2.GetValue("correcta").ToString());
                    //respuestaCorrecta = (bool)jIndex2.GetValue("correcta");

                    if ((int)jIndex2.GetValue("id_pregunta") == idP) 
                    {
                        for (int i = 0; i < jOutput2.Count; i++)
                        {
                            JObject jRes = (JObject)jOutput2[i];
                            comboBox1.Items.Add(jRes.GetValue("respuesta"));
                        }
                        
                    }
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
                    idP = (int)jIndex.GetValue("id");
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
