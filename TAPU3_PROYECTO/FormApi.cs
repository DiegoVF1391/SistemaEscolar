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
    public partial class FormApi : Form
    {
        private String miWS = "http://192.168.0.18:9000/WS2021/ver_catalogo.php";
        private String apiClima = "https://api.openweathermap.org/data/2.5/weather?q=Morelia&lang=es&units=metric&appid=d7830285419c508e732ba5357594d148";

        public FormApi()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            String content = await client.GetStringAsync(apiClima);

            richTextBox1.Text = content;

        }
    }
}
