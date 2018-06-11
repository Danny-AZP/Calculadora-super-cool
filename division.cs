using system;

namespace DannyMath
{
    public class Division
    {
        double memoria = 0;
        public double Dividir(double divisor)
        {
            memoria = memoria/divisor;
            return memoria;
        } 
        public double Dividir(double dividendo, double divisor)
        {
            memoria = dividiendo/divisor;
            return memoria;
        }
        //para restar con e resultado anterior
        public class Resta:Division
        {
          double memoria = 0;
        public double Dividir(double divisor)
        {
            memoria = memoria/divisor;
            return memoria;
        } 
        public double Restar(double sustraendo)
        {
            memoria = memoria-sustraendo;
           return memoria;
        }   
        }
         //para sumar con e resultado anterior
        public class Suma:Division
        {
          double memoria = 0;
        public double Dividir(double divisor)
        {
            memoria = memoria/divisor;
            return memoria;
        } 
         public double Sumar(double sumando1)
        {
            memoria = memoria + sumando 1;
            return memoria;  
        }
        }
         //para multiplicar con e resultado anterior
        public class Multiplicacion:Division
        {
          double memoria = 0;
        public double Dividir(double divisor)
        {
            memoria = memoria/divisor;
            return memoria;
        } 
        public double Multiplicar(double multiplicador)
        {
            memoria = memoria*multiplicador;
           return memoria;
        }  
        }
    }
    
}