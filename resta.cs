using system;

namespace DannyMath
{
    public class Resta
    {
        double memoria=0;
        public double Restar(double sustraendo)
        {
            memoria = memoria -sustraendo;
            return memoria;
        } 
        public double Restar(double minuendo, double sustraendo)
        {
            memoria = minuendo-sustraendo;
           return memoria;
        }
        //para realizar una suma con el resultado anterior
        public class Suma:Resta
        {
            double memoria=0;
            public double Restar(double sustraendo)
        {
            memoria = memoria -sustraendo;
            return memoria;
        } 
        public double Sumar(double sumando1)
        {
            memoria = memoria+ sumando1;
            return memoria;  
        }
        }
        //para realizar una division con el resultado anterior
        public class Division:Resta
        {
            double memoria=0;
            public double Restar(double sustraendo)
        {
            memoria = memoria -sustraendo;
            return memoria;
        }
        public double Dividir(double divisor)
        {
            memoria = memoria/divisor;
            return memoria;
        } 
        }
        public class Multiplicacion:Resta
        {
            double memoria=0;
            public double Restar(double sustraendo)
        {
            memoria = memoria -sustraendo;
            return memoria;
        }
        public double Multiplicar(double multiplicando, double multiplicador)
        {
            memoria = memoria*multiplicador;
           return memoria;
        }
        }
    }    
}