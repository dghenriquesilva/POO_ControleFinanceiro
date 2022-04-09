using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ListarClientes();
        }

        public void ListarClientes()
        {
            Clientes c1 = new Clientes();
            List<Clientes> lista = new List<Clientes>(c1.ListarClientes());
            ListViewItem item = null;
            cboClientes.Items.Clear();
            foreach (var x in lista)
            {
                //item = new ListViewItem();
                //item.Text = x.Nome.ToString();
                //item.SubItems.Add(x.IP_Publico.ToString());
                
                cboClientes.Items.Add(x.Nome.ToString());
               
            }
            

        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
