namespace MSF.DesignPatterns._3___Strategy.AbordagemReutilizavel.Strategy
{
    public interface IStrategy<in TRequest, out TResponse>
    {
        TResponse Execute(TRequest request);
    }
}
