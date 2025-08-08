using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroClienteProva.forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbPF.Checked = true;
            labelEMPRESA.Visible = false; //inicialmente o nome fantasia não é visível
            txtEMPRESA.Visible = false; //inicialmente o nome fantasia não é visível
            gerarGradeListViewPf();//gerar a grade para pessoa física
            gerarGradeListViewPj();//gerar a grade para pessoa jurídica
        }

    

        private void rbPF_CheckedChanged(object sender, EventArgs e)
        {
            // CHAME O MÉTODO LIMPAR AQUI PARA ZERAR OS CAMPOS
            Limpar();

            msktCPFCNPJ.Mask = "000.000.000-00"; //CRIAR MASCARA PARA PESSOA FÍSICA
                                                 //alterar os labels para receber os textos de cpf
            msktCPFCNPJ.Text = "CPF";
            
            //alterar a visibilidade do componente para false
            txtSALARIOFAT.Visible = true;
            txtEMPRESA.Visible = false;
            labelEMPRESA.Visible = false;

            labelQTDFILHOSFUNC.Text = "Quantidade Filhos:";
            labelSALFAT.Text = "Salário:";
        }

     

        private void rbPJ_CheckedChanged(object sender, EventArgs e)
        {
            // CHAME O MÉTODO LIMPAR AQUI TAMBÉM
            Limpar();

            msktCPFCNPJ.Mask = "00.000.000/0000-00"; //CRIAR MASCARA PARA PESSOA JURÍDICA
                                                     //alterar os labels para receber os textos de cnpj
            msktCPFCNPJ.Text = "CNPJ";
            labelQTDFILHOSFUNC.Text = "Quantidade Funcionários"; //alterar o label de qtd filhos para qtd funcionários
            labelSALFAT.Text = "Faturamento"; //alterar o label de salário para faturamento
            labelCPFCNPJ.Text = "CNPJ:"; //alterar o label de cpf para cnpj
            //
            //alterar a visibilidade do componente para true
            labelEMPRESA.Visible = true;
            txtEMPRESA.Visible = true;
        }

        private void btLIMPAR_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Limpar()
        {
            txtNOME.Text = string.Empty;
            //mktbNome.clear();- mesma coisa que o de cima
            txtCIDADE.Text = string.Empty;
            msktCPFCNPJ.Text = string.Empty;
            txtEMPRESA.Text = string.Empty;
            txtSALARIOFAT.Text = string.Empty;
            txtQTDFILHOSFUNC.Text = string.Empty;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void gerarGradeListViewPf()
        {
            //gerar a grade para pessoa física
            lvPF.Columns.Add("CPF", 150).TextAlign = HorizontalAlignment.Center;
            lvPF.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lvPF.Columns.Add("Cidade", 150).TextAlign = HorizontalAlignment.Center;
            lvPF.Columns.Add("Qtd Filhos", 150).TextAlign = HorizontalAlignment.Center;
            lvPF.Columns.Add("Salário", 150).TextAlign = HorizontalAlignment.Center;
            lvPF.Columns.Add("Crédito", 150).TextAlign = HorizontalAlignment.Center;
            lvPF.View = View.Details;

        }
        public void gerarGradeListViewPj()
        {
            //gerar a grade para pessoa jurídica
            lvPJ.Columns.Add("CNPJ", 150).TextAlign = HorizontalAlignment.Center;
            lvPJ.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lvPJ.Columns.Add("Cidade", 150).TextAlign = HorizontalAlignment.Center;
            lvPJ.Columns.Add("Qtd Funcionários", 150).TextAlign = HorizontalAlignment.Center;
            lvPJ.Columns.Add("Faturamento", 150).TextAlign = HorizontalAlignment.Center;
            lvPJ.Columns.Add("Nome Fantasia", 150).TextAlign = HorizontalAlignment.Center;
            lvPJ.Columns.Add("Crédito", 150).TextAlign = HorizontalAlignment.Center;
            lvPJ.View = View.Details;

        }

        private void btCADASTRO_Click(object sender, EventArgs e)
        {
            try
            {
                // VERIFICA SE É PESSOA FÍSICA
                if (rbPF.Checked)
                {
                    // --- 1. VALIDAÇÃO DOS CAMPOS ---
                    if (string.IsNullOrWhiteSpace(txtNOME.Text))
                    {
                        MessageBox.Show("O campo 'Nome' é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!msktCPFCNPJ.MaskCompleted)
                    {
                        MessageBox.Show("O campo 'CPF' deve ser preenchido completamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // --- 2. CONVERSÃO SEGURA DOS DADOS NUMÉRICOS ---
                    int qtdFilhos;
                    if (!int.TryParse(txtQTDFILHOSFUNC.Text, out qtdFilhos))
                    {
                        MessageBox.Show("O valor para 'Qtd Filhos' é inválido. Digite apenas números inteiros.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int salario;
                    if (!int.TryParse(txtSALARIOFAT.Text, out salario))
                    {
                        MessageBox.Show("O valor para 'Salário' é inválido. Digite apenas números inteiros.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // --- 3. CRIAÇÃO DO OBJETO PESSOA FÍSICA ---
                    PessoaFisica pf = new PessoaFisica(
                        txtNOME.Text,
                        txtCIDADE.Text,
                        msktCPFCNPJ.Text, // Passa o CPF com a máscara
                        qtdFilhos,
                        salario
                    );

                    // --- 4. ADIÇÃO NA LISTVIEW ---
                    string[] linhaPf = {
                pf.Cpf,
                pf.Nome,
                pf.Cidade,
                pf.QtdFilhos.ToString(),
                pf.Salario.ToString("C0"), // Formata o INT como moeda (R$ 1.234)
                pf.CalculoCredito().ToString("C2") // Pega o DOUBLE e formata como moeda (R$ 12.345,67)
            };
                    ListViewItem item = new ListViewItem(linhaPf);
                    lvPF.Items.Add(item);
                }
                // CASO SEJA PESSOA JURÍDICA
                else
                {
                    // --- 1. VALIDAÇÃO DOS CAMPOS ---
                    if (string.IsNullOrWhiteSpace(txtNOME.Text))
                    {
                        MessageBox.Show("O campo 'Nome' (Razão Social) é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!msktCPFCNPJ.MaskCompleted)
                    {
                        MessageBox.Show("O campo 'CNPJ' deve ser preenchido completamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtEMPRESA.Text))
                    {
                        MessageBox.Show("O campo 'Nome Fantasia' é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // --- 2. CONVERSÃO SEGURA DOS DADOS NUMÉRICOS ---
                    int qtdFuncionarios;
                    if (!int.TryParse(txtQTDFILHOSFUNC.Text, out qtdFuncionarios))
                    {
                        MessageBox.Show("O valor para 'Qtd Funcionários' é inválido. Use apenas números inteiros.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int faturamento;
                    if (!int.TryParse(txtSALARIOFAT.Text, out faturamento))
                    {
                        MessageBox.Show("O valor para 'Faturamento' é inválido. Use apenas números inteiros.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // --- 3. CRIAÇÃO DO OBJETO PESSOA JURÍDICA ---
                    PessoaJuridica pj = new PessoaJuridica(
                        txtNOME.Text,
                        txtCIDADE.Text,
                        msktCPFCNPJ.Text,
                        qtdFuncionarios,
                        txtEMPRESA.Text,
                        faturamento
                    );

                    // --- 4. ADIÇÃO NA LISTVIEW ---
                    string[] linhaPj = {
                pj.Cnpj,
                pj.Nome,
                pj.Cidade,
                pj.QtdFuncionarios.ToString(),
                pj.Faturamento.ToString("C0"),
                pj.NomeEmpresa,
                pj.CalculoCredito().ToString("C2")
            };
                    ListViewItem item = new ListViewItem(linhaPj);
                    lvPJ.Items.Add(item);
                }

                // --- 5. LIMPEZA DOS CAMPOS ---
                // Limpa os campos do formulário após o cadastro bem-sucedido
                Limpar();
            }
            catch (Exception ex)
            {
                // Captura qualquer outro erro inesperado que possa acontecer
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelQTDFILHOSFUNC_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
