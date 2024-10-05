namespace ApiMinimalRBH.Services
{
    public class SumaService : ISumaService
    {
        public string GetSuma(int numero1, int numero2)
        {
            int suma = 0;
            suma = numero1 + numero2;
            return "Resultado de suma es: " + suma;
        }
    }
}
