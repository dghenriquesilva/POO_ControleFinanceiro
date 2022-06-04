using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Clientes cliente;
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
            Form2 frm2 = new Form2(this);
            cliente = null;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string _nomeCliente = "";

            if (cboClientes.SelectedIndex >= 0)
            {

                _nomeCliente = cboClientes.SelectedItem.ToString();

                cliente = new Clientes().ListarCliente(_nomeCliente.ToString());
                cliente.NomeOld = _nomeCliente;
                Form2 frm2 = new Form2(this);
                frm2.ShowDialog();
            }



        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboClientes_Validated(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Clientes c1 = new Clientes();


            if (cboClientes.SelectedItem != null && !String.IsNullOrEmpty(cboClientes.SelectedItem.ToString())  )
            {
                try
                {
                    c1.Nome = cboClientes.SelectedItem.ToString();
                    MessageBox.Show(c1.Deletar(c1) ? "Deletado com êxito!" : "Erro ao deletar cliente");

                }
                catch (Exception err)
                {
                    throw err;
                }
                c1 = null;
            }
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdConectar_Click(object sender, EventArgs e)
        {
            Form frm3 = new Form3();
            frm3.ShowDialog();
        }
    }
}
