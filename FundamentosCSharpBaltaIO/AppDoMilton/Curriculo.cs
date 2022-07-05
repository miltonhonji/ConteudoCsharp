using System;

namespace AppDoMilton
{
    class Curriculo
    {
        static void Main(string[] args)
        {
            string nome = "Milton";
            string endereco = "Alameda Antares,66";
            string cep = "18555-302";
            string cidade = "Boituva";
            string estado = "SP";
            string email = "miltonhonji@gmail.com.br";
            int idade = 36;
            string nacionalidade = "brasileira";
            char sexo = 'M'; //Use o 'M' ou 'F'
            string textoSexo = "";
            char estadoCivil = 'C'; //Use o 'S' ou 'C'
            string textoEstadoCivil = "";
            string telefone = "11-95292-5113";
            bool trabalhaAtualmente = false;
            string cargo = "Desenvolvedor .NET C#";

            Console.WriteLine(nome);
            Console.WriteLine(endereco);
            Console.WriteLine(cep);
            Console.WriteLine(cidade);
            Console.WriteLine(estado);
            Console.WriteLine(email);
            Console.WriteLine(idade);
            Console.WriteLine(nacionalidade);

            if (sexo == 'M')
            {
                textoSexo = "Masculino";
            }
            else if (sexo == 'F')
            {
                textoSexo = "Feminino";
            }
            Console.WriteLine(textoSexo);

            if (estadoCivil == 'S')
            {
                textoEstadoCivil = "Solteiro";
            }
            else if (estadoCivil == 'C')
            {
                textoEstadoCivil = "Casado";
            }
            else
            {
                textoEstadoCivil = "União Estável";
            }

            Console.WriteLine(textoEstadoCivil);

            Console.WriteLine(telefone);
            Console.WriteLine(trabalhaAtualmente);

            switch (idade)
            {
                case 35: Console.WriteLine("Ops... Preciso atualizar o meu currículo"); break;
                case 36: Console.WriteLine("Currículo atualizado com sucesso!"); break;
                default: Console.WriteLine("O sistema atualizou sozinho"); break;
            }

            switch (cargo)
            {
                case "Desenvolvedor .NET C#": Console.WriteLine("Este é o cargo do Milton"); break;
                case "Gerente de Projetos": Console.WriteLine("Este ainda não é o cargo do Milton"); break;
                default: Console.WriteLine("Ainda não decidi"); break;
            }

            // for (int i = 0; i <= 6;i++)
            //     Console.WriteLine(i);

            // for(int i = 5; i >= 0; i--)
            //     Console.WriteLine(i);

            // for (int m = 0; m <5; m++)
            //     Console.WriteLine(m);

            int valor = 1986;

            do
            {
                Console.WriteLine(valor);
                valor++;
            } while (valor <= 2022);

            // int experienciaNoIcepex = 0;

            // while(experienciaNoIcepex <= 7)
            // {
            //     Console.WriteLine(experienciaNoIcepex);
            //     experienciaNoIcepex++;
            // }        
        }
    }
}