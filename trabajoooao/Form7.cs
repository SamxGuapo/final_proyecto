using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trabajoooao
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
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
                String guery = "INSERT INTO Dinero (Cedula , Nombres , Apellidos , Prestamo , Saldo , Valorprestamo, Valorcuota,Totaldebe)VALUES( @Cedula , @Nombres , @Apellidos , @Prestamo, @Saldo, @Valorprestamo , @Valorcuota,@Totaldebe)";
                MySqlCommand cmd = new MySqlCommand (guery, conexion);
                cmd.Parameters.AddWithValue("@Cedula", TXTCEDULA.Text);
                cmd.Parameters.AddWithValue("@Nombres", TXTNOMBRES.Text);
                cmd.Parameters.AddWithValue("@Apellidos", TXTAPELLIDOS.Text);
                cmd.Parameters.AddWithValue("@Prestamo", TXTPRESTAMO.Text);
                cmd.Parameters.AddWithValue("@Saldo", TXTSALDO.Text);
                cmd.Parameters.AddWithValue("@Valorprestamo", TXTVALOR.Text);
                cmd.Parameters.AddWithValue("@Valorcuota", TXTCUOTA.Text);
                cmd.Parameters.AddWithValue("@Totaldebe", TXTDEBE.Text);



                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Datos guardados exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void TXTTOTAL_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TXTCEDULA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void TXTAPELLIDOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void TXTCEDULA_TextChanged(object sender, EventArgs e)
        {
            string guery = "SELECT plata.Nombres,plata.Apellidos,plata.ID,Cantidad,Cuota FROM Datos INNER JOIN plata ON Datos.Cedula=plata.Cedula WHERE Datos.Cedula=@Cedula";


            MySqlConnection conexion = CONEXION_SQL.conectarSQL();
            MySqlCommand cmd = new MySqlCommand (guery, conexion);
            cmd.Parameters.AddWithValue("@Cedula", TXTCEDULA.Text);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
               
                TXTNOMBRES.Text = reader["Nombres"].ToString();
                TXTAPELLIDOS.Text = reader["Apellidos"].ToString();
                TXTVALOR.Text = reader["Cantidad"].ToString();
                TXTCUOTA.Text = reader["Cuota"].ToString();
                TXTPRESTAMO.Text = reader["ID"].ToString();

            }
             

        }
        
       
    
    
            
            
        private void TXTNOMBRES_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TXTAPELLIDOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TXTPRESTAMO_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTSALDO_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TXTSALDO_Validated(object sender, EventArgs e)
        {

        }

        private void TXTDEBE_Validated(object sender, EventArgs e)
        {
            decimal resultado = (Convert.ToDecimal(TXTVALOR.Text) - Convert.ToDecimal(TXTSALDO.Text));
            TXTDEBE.Text = resultado.ToString("C2");



        }

        private void TXTCUOTA_Validated(object sender, EventArgs e)
        {
            
        }

        private void TXTDEBE_TextChanged(object sender, EventArgs e)
        {
            
            

            

        }

        private void TXTDEBE_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TXTCUOTA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
