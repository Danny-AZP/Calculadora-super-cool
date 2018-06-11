using system;

namespace DannyMath
{
    public class Suma
    {
        double memoria = 0;
        public double Sumar(double sumando)
        {
            memoria = memoria + sumando;
            return memoria;
        } 
        public double Sumar(double sumando, double sumando1)
        {
            memoria = sumando + sumando 1;
            return memoria;  
        }
            //para restar con el resultado anterior
        public class Resta:Suma
        {
          double memoria = 0;
        public double Sumar(double sumando)
        {
            memoria = memoria + sumando;
            return memoria;
        } 
        public double Restar(double sustraendo)
        {
            memoria = memoria-sustraendo;
           return memoria;
        }   
        }
         //para dividir con e resultado anterior
        public class Division:Suma
        {
          double memoria = 0;
        public double Sumar(double sumando)
        {
            memoria = memoria + sumando;
            return memoria;
        } 
         public double Dividir(double divisor)
        {
            memoria = memoria/divisor;
            return memoria;
        }
        }
         //para multiplicar con el resultado anterior
        public class Multiplicacion:Suma
        {
          double memoria = 0;
        public double Sumar(double sumando)
        {
            memoria = memoria + sumando;
            return memoria;
        } 
         public double Multiplicar(double multiplicador)
        {
            memoria = memoria*multiplicador;
           return memoria;
        }
    }
    
}