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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes c1 = new Clientes();
            c1.Nome = txtNome.Text;
            c1.IP_Publico = txtIps.Text;
            c1.Servidores.Enderecos = txtrdp.Text;
            if (c1.SalvarCliente())
            {

                MessageBox.Show("Cliente salvo com èxito!");
            }
            else
            {
                MessageBox.Show("Erro ao tentar salvar:");
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.ActiveForm.Activate();
            
        }
    }
}
