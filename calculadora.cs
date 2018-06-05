 using System;

namespace Danny.Math
{
    public class Calculadora
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
        public double Multiplicar(double multiplicador)
        {
           memoria = memoria*multiplicador;
            return memoria;
        }
        public double Multiplicar(double multiplicando, double multiplicador)
        {
            memoria = multiplicando*multiplicador;
           return multiplicando*multiplicador;
        }

        public double Dividir(double divisor)
        {
            memoria = memoria/divisor;
            return memoria;
        } 
        public double Dividir(double dividendo, double divisor)
        {
            return dividiendo/divisor;
        }
    }
}
