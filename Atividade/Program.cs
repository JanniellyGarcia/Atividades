using System;
using System.Collections.Generic;
using Atividade.Models;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("____Bem-Vindo ao Menu de Atividades____\n");

            //Digitar a opção do menu para as opções existentes:
            //1- Atividade 1
            //2- Atividade 2
            //3- Atividade 3
            Console.WriteLine("Digite a opção desejada:\n(1) para atividade 1\n(2) para atividade 2\n(3) para atividade 3");
            int option = Int32.Parse(Console.ReadLine());


            bool validation = true;
            while (validation)
            {
                switch (option)
                {
                    //Caso escolha atividade 1:
                    case 1:
                        Console.Clear();
                        Console.WriteLine("____Calculadora de: Média de Idades e Idade Maior e Menor____\n");

                        List<int> ages = new List<int>();

                        //Receber os valores da lista:
                        for(int i=1; i <= 5; i++)
                        {
                            Console.WriteLine("Digite a idade da " + i+"ª pessoa:");
                            int age = Int32.Parse(Console.ReadLine());
                            ages.Add(age);
                        }
                        
                        activityOne answeObjectOne = ReturnPropertiesOne(ages);

                        //resultados:
                        Console.WriteLine("A média das idades é:"+answeObjectOne.averageAge);
                        Console.WriteLine("A maior das idades é:" + answeObjectOne.olderAge);
                        Console.WriteLine("A menor das idades é:" + answeObjectOne.youngerAge);

                        //Opção de parada:
                        Console.WriteLine("Tecle 5 para finalizar ou 6 para calcular novamente:");
                        int item = Int32.Parse(Console.ReadLine());

                        if (item == 5)
                        {
                            validation = false;
                        }
                        break;

                    //Caso escolha atividade 2:
                    case 2:
                        Console.Clear();
                        Console.WriteLine("____Calculadora de: Raiz quadrada e Área do Círculo____\n");


                        Console.WriteLine("Digite um número para o cálculo da raiz:");
                        double number = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o raio do círculo:");
                        double radiusCircle = double.Parse(Console.ReadLine());

                        activityTwo answerObjectTwo = resultPropertiesTwo(number, radiusCircle);

                        //resultados:
                        if (radiusCircle >=0 )
                        {
                            Console.WriteLine("A área do círculo de raio " + radiusCircle + " é: " + answerObjectTwo.areaCircle);
                        }
                        else
                        {
                            Console.WriteLine("Não existe área negativa, logo, o raio não pode ser negativo!");
                        }
                        if (number >= 0)
                        {
                            Console.WriteLine("A raiz de " + number + " é: " + answerObjectTwo.root);
                        }
                        else
                        {
                            Console.WriteLine("Não existe raiz real de número negativo!");
                        }

                        //Opção de parada:
                        Console.WriteLine("Tecle 5 para finalizar ou 6 para calcular novamente:");
                        int item2 = Int32.Parse(Console.ReadLine());
                        if (item2 == 5)
                        {
                            validation = false;
                        }

                        break;

                    //Caso escolha atividade 3:
                    case 3:
                        Console.Clear();
                        Console.WriteLine("____Calculadora de: Desconto salarial____\n");

                        //Receber salario do funcionário:
                        Console.WriteLine("Qual é o salário do Funcionário?");
                        double salary = double.Parse(Console.ReadLine());

                        activityThree answeObjectThree = ResultPropertiesThree(salary);

                        //resultados:
                        Console.WriteLine("O valor do salário anterior: R$" +salary);
                        Console.WriteLine("O valor do salário atual: R$" + answeObjectThree.currentSalary);
                        Console.WriteLine("Total de descontos:  R$" + answeObjectThree.fullRate);
                        Console.WriteLine("\n\nTecle 5 para finalizar ou 6 para calcular novamente:");
                        int item3 = Int32.Parse(Console.ReadLine());

                        //Opção de parada:
                        if (item3 == 5)
                        {
                            validation = false;
                        }
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("\n Operação Finalizada! Obrigada por usar nossos serviços.");

            }
        }

        // Método da atividade 1:
       public static activityOne ReturnPropertiesOne(List<int> ages)
        {
            activityOne at1 = new();

            //Fazendo a média;
            double sum = 0;
            foreach (var item in ages)
            {
                sum += item;
                at1.averageAge = sum / 5;

            }

            
            at1.olderAge = 0;
            at1.youngerAge = 0;
            foreach (var position in ages)
            {
                //Retornando a maior idade:
                if (position >= at1.olderAge)
                {
                    at1.olderAge = position;
                }

                //Retornando a menor idade:
                if (at1.youngerAge == 0)
                {
                    at1.youngerAge = position;
                }
                if (position <=at1.youngerAge)
                {
                    at1.youngerAge = position;
                }

            }
            return at1;
    
        }


        //Método da atividade 2: 
        public static activityTwo resultPropertiesTwo(double number, double radius)
        {
            activityTwo at2 = new();
            //Fazendo a raiz:
            at2.root = Math.Sqrt(number);
            //Calculando a área do círculo:
            at2.areaCircle = Math.PI * (Math.Pow(radius, 2));
            return at2;

        }

        //Método da atividade 3: 
        public static activityThree ResultPropertiesThree(double salary)
        {
            activityThree at3 = new();
            if (salary >= 2000)
            {
                at3.fullRate = salary * (0.11 + 0.06 + 0.08);
                at3.currentSalary = salary - at3.fullRate;
            }
            else
            {
                at3.fullRate = salary * (0.11 + 0.06);
                at3.currentSalary = salary - at3.fullRate;
            }
            return at3;

        }
    }

}
