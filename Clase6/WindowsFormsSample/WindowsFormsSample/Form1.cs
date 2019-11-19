using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* FileInfo f = new FileInfo(@"C:\AdventureWorks2016CTP3.bak");
             FileStream fs = f.OpenRead();
             StreamReader reader = new StreamReader(fs);
             //string contenido = await reader.ReadToEndAsync();
             Task<string> task = reader.ReadToEndAsync();
             MessageBox.Show("Empece a leer el archivo");
             string res = await task;
             MessageBox.Show("Archivo leido");

             //string contenido = File.ReadAllText(@"C:\AdventureWorks2016CTP3.bak");
             //MessageBox.Show("Archivo Leido"); */
            string connstr = @"Data Source=.\SQLEXPRESS;Initial Catalog=AccentureAcademyAsync.Sql;Integrated Security=True";
            List<String> nombres = new List<String>();

            using (SqlConnection sqlConnection = new SqlConnection(connstr))
            {
                sqlConnection.Open();
                SqlCommand sql = new SqlCommand();
                sql.Connection = sqlConnection;
                sql.CommandText = "select * from Nombres";
                SqlDataReader reader = sql.ExecuteReader();

                foreach(DbDataRecord registro in reader)
                {
                    nombres.Add(registro.GetString(registro.GetOrdinal("Nombre")));
                }

                string path = @"E:\Proyectos\AlanMartinez\Repositorio\Clase6\nombres";
                
                if(File.Exists(path))
                {
                    File.Delete(path);
                }

                using (FileStream fs = File.Create(path))
                {
                    foreach(string nombre in nombres)
                    {
                        AddText(fs, $"\r\n {nombre}");
                    }
                }


            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton presionado");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
