using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agenda {
    public partial class Form1 : Form {
        List<Contacto> contactos = new List<Contacto>();

        public Form1() {
            InitializeComponent();
            select();
        }

        public void select() {
            dataGridView1.DataSource = "";
            MySqlConnection conn = conectar();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from contactos ORDER BY nombre";
            conn.Open();
            MySqlDataReader data = cmd.ExecuteReader();
            contactos.Clear();
            while (data.Read()) {
                contactos.Add(new Contacto((string)data["nombre"], (int) data["edad"], (int)data["telefono"], (string)data["direccion"], (string)data["email"]));
            }
            conn.Close();
            dataGridView1.DataSource = contactos;
        }
        
        public void insert(string nombre, int edad, int telefono, string direccion, string email) {
            MySqlConnection conn = conectar();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO contactos (nombre,telefono,direccion, email) value ('" + nombre + "'," + edad + "," + telefono + ",'" + direccion + "','" + email + "')";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            contactos.Add(new Contacto(nombre, edad, telefono, direccion, email));
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = contactos;
        }

        public void delete() {
            MySqlConnection conn = conectar();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Delete from contactos where contactos.nombre='"+Bnom.Text+"';";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            select();
        }


        //Funcion modificar contacto
        public void update()
        {
            MySqlConnection conn = conectar();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE contactos SET nombre = '" + Mnom2.Text + "', edad = " + Medad.Text + ", telefono = " + Mtel.Text + ", direccion = '" + Mdir.Text + "', email = '" + Memail.Text 
                + "' WHERE contactos.nombre ='" +  Bnom.Text + "';";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            select();
        }

        public String CrearCadenaConexion() {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.137.1";
            builder.UserID = "java";
            builder.Password = "java";
            builder.Database = "agendasharp";
            return builder.ToString();
        }
        public MySqlConnection conectar() {
            MySqlConnection conn = new MySqlConnection(CrearCadenaConexion());
            return conn;
        }

        //Insertar
        private void insertar_Click(object sender, EventArgs e) {
            insert(tNombre.Text, Convert.ToInt32(tEdad.Text), Convert.ToInt32(tTelefono.Text),tDireccion.Text,tEmail.Text);
            tNombre.Text = "";
            tEdad.Text = "";
            tTelefono.Text = "";
            tDireccion.Text = "";
            tEmail.Text = "";
            MessageBox.Show("Se ha insertado correctamente", "Contacto creado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            Bnom.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Mnom2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Mtel.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Mdir.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Memail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        //Borrar
        private void button2_Click(object sender, EventArgs e)
        {
            delete();
            Mnom2.Text = "";
            Mtel.Text = "";
            Mdir.Text = "";
            Memail.Text = "";
            Bnom.Text = "";
            MessageBox.Show("Se ha borrado correctamente", "Contacto borrado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //Modificar
        private void button3_Click(object sender, EventArgs e) {
            update();
            Mnom2.Text = "";
            Mtel.Text = "";
            Mdir.Text = "";
            Memail.Text = "";
            Bnom.Text = "";
            MessageBox.Show("Se ha modificado correctamente", "Contacto modificado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
    //Clase contacto
    public class Contacto
    {
        public Contacto(string nombre, int edad, int telefono, string direccion, string email)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.edad = edad;
            this.direccion = direccion;
            this.email = email;
        }
        public string nombre { get; set; }
        public int telefono { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }

    }    
}
