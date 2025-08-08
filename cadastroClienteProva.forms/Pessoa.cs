using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroClienteProva.forms
{
    public abstract class Pessoa
    {
        protected string nome;
        protected string cidade;

        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        public Pessoa(string nome, string cidade)
        {
            this.nome = nome;
            this.cidade = cidade;
        }
        // Método de cálculo de crédito virtual.
        // Cada subclasse terá sua própria fórmula.
        public virtual double CalculoCredito()
        {
            return 0.0;
        }
    }
}
