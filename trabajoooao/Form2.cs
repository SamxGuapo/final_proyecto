using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace trabajoooao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ingre_Click(object sender, EventArgs e)
        {

        }

        private void resgis_Click(object sender, EventArgs e)
        {
            this.Hide();
            registroo regis = new registroo();
            regis.ShowDialog();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string guery = "SELECT Usuario,Contraseña FROM Ingreso WHERE Usuario=@Usuario AND Contraseña=@Contraseña";
            MySqlConnection conec = CONEXION_SQL.conectarSQL();             
            MySqlCommand cmd = new MySqlCommand (guery, conec);
            cmd.Parameters.AddWithValue("Usuario", TxtUsuario.Text);
            cmd.Parameters.AddWithValue("Contraseña",txtContraseña.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                this.Hide();
                bienvenida Form2 = new bienvenida();
                Form2.ShowDialog();

            }
            else
            {

                MessageBox.Show("Usuario o Contraseña incorrecto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUsuario.Text = "";
                txtContraseña.Text = "";
            }

            
            
            
        }

           
        

           
        

        private void ingresar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrar.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        
    }
}
