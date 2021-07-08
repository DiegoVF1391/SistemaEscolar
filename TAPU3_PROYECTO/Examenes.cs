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
        private int id_materia=0;

        //guardar semestre, respuesta y carrera
        private String car, inciso;
        private int cont = 0, numRespuestas = 0, idP=0, cont2 = 0;
        private int respuestaCorrecta;

        private String materiaCalif;

        JObject jIndex;
        JArray jOutput;

        JObject jIndex2;
        JArray jOutput2;

        private static String Diego = "http://192.168.1.70/my_sge/preguntas.php";
        private static String Marco = "http://192.168.1.10/my_sge/preguntas.php";

        private static String Diegor = "http://192.168.1.70/my_sge/pyr.php";
        private static String Marcor = "http://192.168.1.10/my_sge/pyr.php";

        //para calificar
        private static String DiegoC = "http://192.168.1.70/my_sge/calificar.php";
        private static String MarcoC = "http://192.168.1.10/my_sge/calificar.php";

        String ws = Marco;
        String wsr = Marcor;
        String wsc = MarcoC;
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
                    id_materia = (int)jIndex.GetValue("id_materia");
                    MessageBox.Show("id_materia = "+id_materia);
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
            String respuestas = await client2.GetStringAsync(wsr);
            try
            {
                JObject jsonObject2 = JObject.Parse(respuestas);
                jOutput2 = (JArray)jsonObject2.GetValue("output");

                //MessageBox.Show(idP.ToString());

                for (int i = 0; i < jOutput2.Count; i++)
                {
                    JObject jRes = (JObject)jOutput2[i];
                   
                    if ((int)jRes.GetValue("id_pregunta") == idP)
                    {
                    
                        comboBox1.Items.Add(jRes.GetValue("respuesta"));
                        /*JObject re = (JObject)comboBox1.SelectedItem;
                        if ((int)re.GetValue("correcta") == 1)
                        {
                            numRespuestas += 1;
                            MessageBox.Show("Correcto!");
                        }
                        else 
                        {
                            numRespuestas += 0;
                            MessageBox.Show("Andas en las nubes!");
                        }*/

                    }
                }

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
            revisar();
            pregunta();
            if (!comboBox1.SelectedIndex.ToString().Equals("-1"))
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
            }
        }

        private async void pregunta()
        {
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

                    //agregar respuestas 
                    try
                    {
                        HttpClient client2 = new HttpClient();
                        String respuestas = await client2.GetStringAsync(wsr);
                        JObject jsonObject2 = JObject.Parse(respuestas);
                        jOutput2 = (JArray)jsonObject2.GetValue("output");

                        //MessageBox.Show(idP.ToString());
                        //respuestaCorrecta = (bool)jIndex2.GetValue("correcta");

                        for (int i = 0; i < jOutput2.Count; i++)
                        {
                            JObject jRes = (JObject)jOutput2[i];

                            if ((int)jRes.GetValue("id_pregunta") == idP)
                            {
                                comboBox1.Items.Add(jRes.GetValue("respuesta"));
                            }
                        }

                    }
                    catch (Exception ix)
                    {
                        Console.WriteLine("Error: "+ix);
                        MessageBox.Show("Error al accesar a la BD");
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted obtuvo " + numRespuestas);
                calificarExamen();
                this.Dispose();
            }
        }

        public void revisar() 
        {
            for (int i = 0; i < jOutput2.Count; i++)
            {

                JObject re = (JObject)jOutput2[i];

                //revisar respuestas que coincida con el item seleccionado
                if (re.GetValue("respuesta").ToString() == comboBox1.SelectedItem.ToString())
                {
                    //MessageBox.Show(re.GetValue("respuesta").ToString());
                    //revisar valor 
                    if ((int)re.GetValue("correcta") == 1)
                    {
                        numRespuestas += 10;
                        //MessageBox.Show("Correcto!");
                    }
                    else
                    {
                        numRespuestas += 0;
                        //MessageBox.Show("Andas en las nubes!");
                    }

                }

               
            }
           
        }

        public async void calificarExamen()
        {
            try
            {
                MessageBox.Show("user: "+Form1.index +" materia: "+id_materia+" califiacion:"+numRespuestas);
                HttpClient client3 = new HttpClient();
                String content = await client3.GetStringAsync(wsc + "?usr=" + Form1.index
                    + "&materia=" + id_materia + "&calif=" + numRespuestas);
                MessageBox.Show(content+" Calificado");

            }
            catch (Exception ox)
            {
                Console.WriteLine("Error "+ox);
                MessageBox.Show("Error, intente mas tarde...");
                throw;
            }
         

        }


    }
}
