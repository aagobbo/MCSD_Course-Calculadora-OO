namespace Mind.Calculadora.Dominio
{
    public class Multiplicacao : Operadora
    {
        public override double RealizarOperacao(int numero1, int numero2) => numero1 * numero2;
    }
}