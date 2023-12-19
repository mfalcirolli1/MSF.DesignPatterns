using MSF.DesignPatterns._2___Factory_Method.CartaoCredito;
using MSF.DesignPatterns._2___Factory_Method.Creator;
using MSF.DesignPatterns._2___Factory_Method.Model;

namespace MSF.DesignPatterns._2___Factory_Method.ConcreteCreator.CartaoCredito
{
    internal class CartaoBlackFactory : CartaoCreditoCreator
    {
        public int _limite;
        public int _cobrancaAnual;

        public CartaoBlackFactory(int limite, int cobrancaAnual)
        {
            _limite = limite;
            _cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCreditoModel BuscarCartaoCredito()
        {
            return new CartaoBlack(_limite, _cobrancaAnual);
        }
    }
}
