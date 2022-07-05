using System;

namespace InterpolacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 37.9;

            //var texto = "O meu carro custa " + price + " mil reais";

            //var texto = string.Format("O meu carro está avaliado em {0} em reais e sofreu um reajuste de {1} porcento", price, aumento);

            var texto = $"O preço do carro está {price} reais";

            /*var texto = @$"O preço do carro Up da empresa Volkswagen 
            ano 2014 está avaliado { price } reais";*/

            //var texto = $"O preço do carro da Up da empresa Volkswagen \n do ano 2014 está avaliado em {price} reais.";

            Console.WriteLine(texto);
        }
    }
}