namespace Mind.Calculadora.Dominio
{
    public class Divisao : Operadora
    {
        public override double RealizarOperacao(int numero1, int numero2) => (double) numero1 / (double) numero2;
    }
}