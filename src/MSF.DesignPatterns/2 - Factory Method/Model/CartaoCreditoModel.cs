namespace MSF.DesignPatterns._2___Factory_Method.Model
{
    public abstract class CartaoCreditoModel
    {
        public abstract string Tipo { get; }
        public abstract int Limite { get; set; }
        public abstract int CobrancaAnual { get; set; }
    }
}
