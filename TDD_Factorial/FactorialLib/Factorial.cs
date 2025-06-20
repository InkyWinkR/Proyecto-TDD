public class Calculadora
{
    public int Factorial(int numero)
    {
        if (numero < 0)
            throw new ArgumentException("No se puede calcular factorial de números negativos");

        if (numero == 0 || numero == 1)
            return 1;

        int resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }

}
