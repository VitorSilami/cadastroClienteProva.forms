using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroClienteProva.forms
{
    class PessoaFisica : Pessoa
    {
        private string cpf;
        private int qtdFilhos;
        private int salario;

        public string Cpf { get => cpf; set => cpf = value; }
        public int QtdFilhos { get => qtdFilhos; set => qtdFilhos = value; }
        public int Salario { get => salario; set => salario = value; }

        public PessoaFisica(string nome, string cidade, string cpf, int qtdFilhos, int salario) : base(nome, cidade)
        {
            this.cpf = cpf;
            this.qtdFilhos = qtdFilhos;
            this.salario = salario;
        }
        public override double CalculoCredito()
        {
            // Aplicando sua nova fórmula
            double credito = this.Salario * 12 - this.QtdFilhos * 10;
            return credito;
        }
    }
}
