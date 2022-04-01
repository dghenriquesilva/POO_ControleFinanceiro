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
            ColunasListView();
            CelulasListView();
        }
        public void ColunasListView()
        {

            lstvDados.Columns.Add("ID", 5 * (int)lstvDados.Font.SizeInPoints, HorizontalAlignment.Center);
            lstvDados.Columns.Add("CLIENTE)", 30 * (int)lstvDados.Font.SizeInPoints, HorizontalAlignment.Center);
            lstvDados.Columns.Add("IP(S) PUBLICO(S)", 30 * (int)lstvDados.Font.SizeInPoints, HorizontalAlignment.Center);
            lstvDados.Columns.Add("SERVIDOR RDP", 30 * (int)lstvDados.Font.SizeInPoints, HorizontalAlignment.Center);
            lstvDados.Columns.Add("PORTA LOCAL", 30 * (int)lstvDados.Font.SizeInPoints, HorizontalAlignment.Center);
            
        }
        public void CelulasListView()
        {
            Clientes c1 = new Clientes();
            List<Clientes> lista = new List<Clientes>(c1.ListarClientes());
            lstvDados.SelectedItems.Clear();
            ListViewItem items = new ListViewItem();
            foreach (var x in lista)
            {
                items.Text = x.ID.ToString();
                items.SubItems.Add(x.Nome.ToString());
            }
            lstvDados.Items.Add(items);

        }
    }
}
