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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            bienvenida form6 = new bienvenida();
            form6.Show();
            this.Hide();
        }

        private void textGuardar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = CONEXION_SQL.conectarSQL();
            {
                String guery = "INSERT INTO Plata (Cedula,Nombres,Apellidos,Cantidad,interes,Cancelar,Cuota)VALUES(@Cedula,@Nombres,@Apellidos,@Cantidad,@interes,@Cancelar,@Cuota)";
                MySqlCommand cmd = new MySqlCommand (guery, conexion);

                cmd.Parameters.AddWithValue("@Cedula", Cedulatxt.Text);
                cmd.Parameters.AddWithValue("@Nombres", Nombrestxt.Text);
                cmd.Parameters.AddWithValue("@Apellidos", Apellidostxt.Text);
                cmd.Parameters.AddWithValue("@Cantidad", Prestamotxt.Text);
                cmd.Parameters.AddWithValue("@interes", Interestxt.Text);
                cmd.Parameters.AddWithValue("@Cuota", Cuotatxt.Text);
                cmd.Parameters.AddWithValue("@Cancelar", Cancelartxt.Text);
                


                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Datos guardados exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                datosalmacenados.Rows.Add(Cedulatxt.Text, Nombrestxt.Text, Apellidostxt.Text, Prestamotxt.Text, Interestxt.Text, Cancelartxt.Text, Cuotatxt.Text);
            }
        }

        private void datosalmacenados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nombrestxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cedulatxt_TextChanged(object sender, EventArgs e)
        {


            string guery = "SELECT Cedula, Nombres, Apellidos FROM Datos WHERE Cedula=@Cedula";

            MySqlConnection conexion = CONEXION_SQL.conectarSQL();
            MySqlCommand cmd = new MySqlCommand(guery, conexion);
            cmd.Parameters.AddWithValue("@Cedula", Cedulatxt.Text);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Cedulatxt.Text = reader["Cedula"].ToString();
                Nombrestxt.Text = reader["Nombres"].ToString();
                Apellidostxt.Text = reader["Apellidos"].ToString();


            }
        }
       



        private void button1_Click(object sender, EventArgs e)
        {
            Cedulatxt.Text = "";
            Nombrestxt.Text = "";
            Apellidostxt.Text = "";
            Prestamotxt.Text = "";
            Interestxt.Text = "";
            Cancelartxt.Text = "";
            Cuotatxt.Text = "";

            
        }

        private void Cedulatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void Apellidostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void Cuotatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Cuotatxt_TextChanged(object sender, EventArgs e)
        {
            
            

            
            
               
        }

        private void Cuotatxt_Validated(object sender, EventArgs e)
        {
           if (Prestamotxt.Text != "")
            { 
                
                decimal resultado = (Convert.ToDecimal(Prestamotxt.Text) * Convert.ToDecimal(Interestxt.Text)) / 100;
                decimal Ndias = Convert.ToDecimal(Cancelartxt.Text);
                decimal Rinteres=(Convert.ToDecimal(Prestamotxt.Text)+resultado) / Ndias;
                Cuotatxt.Text= Rinteres.ToString("C2");
            }
        }

        private void Cancelartxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Prestamotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Interestxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Interestxt_Validated(object sender, EventArgs e)
        {

        }
    }
}
