using System.Globalization;


namespace PagamentoComissao
{
    class Vendedor
    {

        public string Nome { get; set; }
        public int CodigoPeca { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }


        public Vendedor() { }

        public Vendedor(string nome, int codigoPeca, double precoUnitario, int quantidade)
        {
            Nome = nome;
            CodigoPeca = codigoPeca;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }


        public double totalVenda
        {
            get { return PrecoUnitario * Quantidade; }
        }

        public double comissao
        {
            get { return PrecoUnitario * Quantidade * 0.05;  }
        }


        public override string ToString()
        {
            return "Nome: "
                + Nome
                + "\n"
                + "Codigo da Peça: "
                + CodigoPeca
                + "\n"
                + "Preço unitario da peça: "
                + PrecoUnitario.ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "Quatidade vendida: "
                + Quantidade
                + "\n"
                + "Valor total das vendas: "
                + totalVenda.ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "Comissão do vendedor: "
                + comissao.ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "---------------------------------"
                + "\n";
               
        }


    }
}
