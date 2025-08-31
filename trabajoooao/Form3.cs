using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajoooao
{
    public partial class registroo : Form
    {
        public registroo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void mensajes(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = CONEXION_SQL.conectarSQL();
            {
                String guery = "INSERT INTO Ingreso (Identificacion,Nombres,Apellidos,Telefono,Ciudad,Usuario,Contraseña)VALUES(@Identificacion,@Nombres,@Apellidos,@Telefono,@Ciudad,@Usuario,@Contraseña)";
                MySqlCommand cmd = new MySqlCommand (guery, conexion);
                cmd.Parameters.AddWithValue("@Identificacion", textIdentificacion.Text);
                cmd.Parameters.AddWithValue("@Nombres", textNombres.Text);
                cmd.Parameters.AddWithValue("@Apellidos", textApellidos.Text);
                cmd.Parameters.AddWithValue("@Telefono", textTelefono.Text);
                cmd.Parameters.AddWithValue("@Ciudad", textCiudad.Text);
                cmd.Parameters.AddWithValue("@Usuario", textUsuario.Text);
                cmd.Parameters.AddWithValue("@Contraseña", textContraseña.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Datos guardados exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtactualizar_Click(object sender, EventArgs e)
        {
            string guery = "UPDATE Ingreso SET Identificacion=@Identificacion,Nombres=@Nombres,Apellidos=@Apellidos,Telefono=@Telefono,Ciudad=@Ciudad,Contraseña=@Contraseña WHERE Identificacion=@Identificacion";
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion = CONEXION_SQL.conectarSQL();
                MySqlCommand cmd = new MySqlCommand(guery, conexion);
                cmd.Parameters.AddWithValue("@Identificacion", textIdentificacion.Text);
                cmd.Parameters.AddWithValue("@Nombres", textNombres.Text);
                cmd.Parameters.AddWithValue("@Apellidos", textApellidos.Text);
                cmd.Parameters.AddWithValue("@Telefono", textTelefono.Text);
                cmd.Parameters.AddWithValue("@Ciudad",textCiudad.Text);
                cmd.Parameters.AddWithValue("@Contraseña", textContraseña.Text);
                 
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Datos actualizados!", "BD_PROYECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
            }
            finally
            {

            }
        }

        private void txtnuevo_Click(object sender, EventArgs e)
        {
            textIdentificacion.Text = "";
            textNombres.Text = "";
            textApellidos.Text = "";
            textTelefono.Text = "";
            textCiudad.Text = "";
            textUsuario.Text = "";
            textContraseña.Text = "";
        }

        private void datosalmacenados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 bienvenida = new Form2();
            bienvenida.Show();
            this.Hide();
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void textNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void textApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void textCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void textIdentificacion_TextChanged(object sender, EventArgs e)
        {
            string guery = "SELECT Identificacion, Nombres, Apellidos,Telefono, Ciudad, Usuario, Contraseña From Ingreso WHERE Identificacion=@Identificacion";

            MySqlConnection conexion = CONEXION_SQL.conectarSQL();
            MySqlCommand cmd = new MySqlCommand(guery, conexion);
            cmd.Parameters.AddWithValue("@Identificacion", textIdentificacion.Text);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textIdentificacion.Text = reader["Identificacion"].ToString();
                textNombres.Text = reader["Nombres"].ToString();
                textApellidos.Text = reader["Apellidos"].ToString();
                textTelefono.Text = reader["Telefono"].ToString();
                textCiudad.Text = reader["Ciudad"].ToString();
                textUsuario.Text = reader["Usuario"].ToString();
                textContraseña.Text = reader["Contraseña"].ToString();

            }
        }
    }
}
