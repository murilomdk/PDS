using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        
        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFornecedor formFornecedor = new FormFornecedor();
            formFornecedor.ShowDialog();


        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMotorista formMotorista = new FormMotorista();

            formMotorista.ShowDialog();
        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPecas formPecas = new FormPecas();

            formPecas.ShowDialog();
        }

        private void veiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVeiculo formVeiculo = new FormVeiculo();

            formVeiculo.ShowDialog();
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            
        }
    }
}
