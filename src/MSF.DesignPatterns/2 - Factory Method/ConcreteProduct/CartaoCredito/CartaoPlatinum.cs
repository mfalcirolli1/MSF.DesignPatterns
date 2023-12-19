using MSF.DesignPatterns._2___Factory_Method.Model;

namespace MSF.DesignPatterns._2___Factory_Method.CartaoCredito
{
    public class CartaoPlatinum : CartaoCreditoModel
    {
        public override string Tipo
        {
            get { return _tipo; }
        }

        public override int Limite
        {
            get { return _limite; }
            set { _limite = value; }
        }

        public override int CobrancaAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }

        public string _tipo;
        public int _limite;
        public int _cobrancaAnual;

        public CartaoPlatinum(int limite, int cobrancaAnual)
        {
            _tipo = "Platinum";
            _limite = limite;
            _cobrancaAnual = cobrancaAnual;
        }
    }
}
