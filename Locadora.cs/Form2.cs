using LocadoraClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LocadoraClasses.LocadoraClasses;

namespace Locadora.cs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Endereço = txtEndereco.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.RG = txtRg.Text;
            cliente.CPF = txtCpf.Text;

            Categoria categoria = new Categoria();
            categoria.Id = 1; // Exemplo de ID
            categoria.Nome = "Categoria Exemplo";
            categoria.ValorDiaria = 10.99m;

            Genero genero = new Genero();
            genero.Id = 1; // Exemplo de ID
            genero.Nome = "Gênero Exemplo";

            string mensagem = $"Dados do cliente: \nNome: {cliente.Nome}\nEndereço: {cliente.Endereço}\nTelefone: {cliente.Telefone}\nRG: {cliente.RG}\nCPF: {cliente.CPF}";
            MessageBox.Show(mensagem);

            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
