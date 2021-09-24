using gestor_gimnasio.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_gimnasio
{
    public partial class Form1 : Form
    {
        Gimnasio gym = new Gimnasio();
        List<Cliente> clientes = new List<Cliente>();
        uint selected;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = cbSocio.SelectedIndex;
            selected = clientes[index].IdSocio;
            lblImc.Text = gym.CalcularImc(selected).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSocio.Items.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string res = gym.IngresarSocio(txtnumero.Text, txtnombre.Text, txtapellido.Text, txtpeso.Text, txtaltura.Text);
                lblEstado.Text = "Estado:" + res;
            }
            catch (Exception ef) { }
            cbSocio.Items.Clear();
            clientes = gym.Listado();
            foreach(Cliente c in clientes)
            {
                cbSocio.Items.Add($"{c.Nombre} {c.Apellido}");
            }
        }
    }
}
