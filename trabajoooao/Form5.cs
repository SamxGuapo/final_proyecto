using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajoooao
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void nuevo()
        {

            txtCedula.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtNombres.Text = "";
            txtDireccion.Text = "";
      
            txtDeudor.Text = "";
            txtIdentificacion.Text = "";
            textNumero.Text = "";



        }

        private void button3_Click(object sender, EventArgs e)
        {

            txtCedula.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtNombres.Text = "";
            txtDireccion.Text = "";
         
            txtDeudor.Text = "";
            txtIdentificacion.Text = "";
            textNumero.Text = "";
            nuevo();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {


        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdireccion_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void apel_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conexion = CONEXION_SQL.conectarSQL();
            {
                String guery = "INSERT INTO Datos (Cedula,Nombres,Apellidos,Telefono,Direccion,NDeudor,Identificacion,Numero)VALUES(@Cedula,@Nombres,@Apellidos,@Telefono,@Direccion,@NDeudor,@Identificacion,@Numero)";
                MySqlCommand cmd = new MySqlCommand(guery, conexion);
                cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                cmd.Parameters.AddWithValue("@Nombres", txtNombres.Text);
                cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                cmd.Parameters.AddWithValue("@NDeudor", txtDeudor.Text);           
                cmd.Parameters.AddWithValue("@Identificacion", txtIdentificacion.Text);
                cmd.Parameters.AddWithValue("@Numero", textNumero.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Datos guardados exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bienvenida bienvenida = new bienvenida();
            bienvenida.Show();
            this.Hide();

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void txtDeudor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }
    }
}
