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
    public partial class Form2 : Form
    {
        Form1 instanciaForm1;
        bool editar;
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            instanciaForm1 = frm1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Definir se é para salvar ou editar
            if (instanciaForm1.cliente != null)
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                txtNome.Text = instanciaForm1.cliente.Nome.ToString();
                txtIps.Text = instanciaForm1.cliente.IP_Publico.ToString();
                txtrdp.Text = instanciaForm1.cliente.Enderecos.ToString();

                editar = true;
            }
            else
            {
                editar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Clientes c1 = new Clientes();
                c1.NomeOld = editar == true ? instanciaForm1.cliente.NomeOld : "";
                c1.Nome = txtNome.Text;
                c1.IP_Publico = txtIps.Text;
                c1.Servidores.Enderecos = txtrdp.Text;
                if (editar)
                {
                    editar = false;

                    if (c1.EditarCliente(c1))
                    {

                        MessageBox.Show("Cliente salvo com èxito!");
                        c1.NomeOld = "";

                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar salvar:");
                    }
                }
                else
                {
                    if (c1.SalvarCliente())
                    {

                        MessageBox.Show("Cliente salvo com èxito!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar salvar:");
                    }
                }
            c1 = null;
          
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.ActiveForm.Activate();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtrdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
