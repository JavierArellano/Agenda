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
            MySqlConnection conn = conectar();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from contactos ORDER BY nombre";
            conn.Open();
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read()) {
                contactos.Add(new Contacto((int)data["id"], (string)data["nombre"], (int)data["telefono"], (string)data["direccion"], (string)data["email"]));
            }
            conn.Close();
            dataGridView1.DataSource = contactos;
        }
        
        public void insert(string nombre, int telefono, string direccion, string email) {
            MySqlConnection conn = conectar();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO contactos (nombre,telefono,direccion, email) value ('" + nombre + "'," + telefono + ",'" + direccion + "','" + email + "')";
            conn.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("insertao");
            conn.Close();
            contactos.Add(new Contacto(contactos.Count, nombre, telefono, direccion, email));
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = contactos;
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

        private void insertar_Click(object sender, EventArgs e) {
            insert(tNombre.Text,Convert.ToInt32(tTelefono.Text),tDireccion.Text,tEmail.Text);
            tNombre.Text = "";
            tTelefono.Text = "";
            tDireccion.Text = "";
            tEmail.Text = "";
        }

        
    }
    //Clase contacto
    public class Contacto
    {
        public Contacto(int id, string nombre, int telefono, string direccion, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
        }
        public string nombre { get; set; }
        public int id { get; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }

    }    
}
