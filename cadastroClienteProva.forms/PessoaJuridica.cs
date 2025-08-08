using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroClienteProva.forms
{
    class PessoaJuridica : Pessoa
    {
        private string cnpj;
        private string nomeEmpresa;
        private int qtdFuncionarios;
        private int faturamento;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string NomeEmpresa { get => nomeEmpresa; set => nomeEmpresa = value; }
        public int QtdFuncionarios { get => qtdFuncionarios; set => qtdFuncionarios = value; }
        public int Faturamento { get => faturamento; set => faturamento = value; }

        public PessoaJuridica(string nome, string cidade, string cnpj, int qtdFuncionarios, string nomeEmpresa, int faturamento) : base(nome, cidade)
        {
            this.cnpj = cnpj;
            this.nomeEmpresa = nomeEmpresa;
            this.qtdFuncionarios = qtdFuncionarios;
            this.faturamento = faturamento;
        }
        public override double CalculoCredito()
        {
            // Aplicando sua nova fórmula
            double credito = this.Faturamento * 12 + this.QtdFuncionarios * 10;
            return credito;
        }


    }
}
