double valor1=2;
var calculadoraSuperCool = new calculadora();
var resultado = calculadoraSuperCool.Sumar(valor1, 2);
var resultado = calculadoraSuperCool.Restar(resultado, 3);
var resultado = calculadoraSuperCool.Raiz(resultado);
var resultado = calculadoraSuperCool.Dividir(resultado, 8);
var resultado = calculadoraSuperCool.Multiplicar(resultado, 4);
console.WriteLine("El resultado es:" + resultado)
