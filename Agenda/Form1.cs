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
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        public String CrearCadenaConexion() {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "java";
            builder.Password = "java";
            builder.Database = "interfaz";
            return builder.ToString();
        }
        public MySqlConnection conectar() {
            MySqlConnection conn = new MySqlConnection(CrearCadenaConexion());
            return conn;
        }
    }

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

    }
}
