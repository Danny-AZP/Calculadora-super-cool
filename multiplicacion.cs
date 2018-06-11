using system;

namespace DannyMath
{
    public class Multiplicacion
    {
        double memoria = 0;
         public double Multiplicar(double multiplicador)
        {
           memoria = memoria*multiplicador;
            return memoria;
        }
        public double Multiplicar(double multiplicando, double multiplicador)
        {
            memoria = multiplicando*multiplicador;
           return memoria;
        }
          //para restar con el resultado anterior
        public class Resta:Multiplicacion
        {
        double memoria = 0;
         public double Multiplicar(double multiplicador)
        {
           memoria = memoria*multiplicador;
            return memoria;
        }
        public double Restar(double sustraendo)
        {
            memoria = memoria-sustraendo;
           return memoria;
        }   
        }
         //para sumar con e resultado anterior
        public class Suma:Multiplicacion
        {
         double memoria = 0;
         public double Multiplicar(double multiplicador)
        {
           memoria = memoria*multiplicador;
            return memoria;
        }
         public double Sumar(double sumando1)
        {
            memoria = memoria + sumando 1;
            return memoria;  
        }
        }
         //para dividir con el resultado anterior
        public class Division:Multiplicacion
        {
         double memoria = 0;
         public double Multiplicar(double multiplicador)
        {
           memoria = memoria*multiplicador;
            return memoria;
        }
        public double Dividir(double divisor)
        {
            memoria = memoria/divisor;
            return memoria;
        }
        }
    }
    
}