﻿using System;
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
           if (c1.SalvarCliente())
            {
                MessageBox.Show("Cliente salvo com èxito!");

            }
            else
            {
                MessageBox.Show("Erro ao tentar salvar:");
            }
        }
    }
}