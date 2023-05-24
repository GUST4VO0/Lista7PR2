using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    menu   ");
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("Exercicio 6");
            Console.WriteLine("Exercicio 7");
            int exec = int.Parse(Console.ReadLine());

            switch (exec)
            {
                case 1:

                    int QTotal = 0;
                    double VTotal = 0.0;

                    while (true)
                    {
                        Console.Write("quantos itens você irá comprar? (caso seja 0 o programa se encerrará!) ");
                        int quantidade = int.Parse(Console.ReadLine());

                        if (quantidade <= 0)
                            break;

                        Console.Write("qual o valor do produto que você deseja comprar?");
                        double preco = double.Parse(Console.ReadLine());

                        QTotal += quantidade;
                        VTotal += quantidade * preco;
                    }

                    Console.WriteLine("\nResumo da compra:");

                    Console.WriteLine("Quantidade total de itens comprados: " + QTotal);
                    Console.WriteLine("Sua compra ficou em: R$ " + VTotal.ToString("F2"));

                    Console.WriteLine("\ndigite qualquer tecla para sair.");
                    Console.ReadKey();

                    break;

                case 2:



                    string produto;
                    int quant;
                    decimal precoCompra;

                    string NomeProdutoMaisInvestido = "";
                    decimal MInv = decimal.MinValue;

                    string nomeProdutoMenosInvestido = "";
                    decimal menorInvestimento = decimal.MaxValue;

                    while (true)
                    {
                        Console.Write("Digite o nome do produto,se caso querer encerrar digite 'parar': ");
                        produto = Console.ReadLine();

                        if (produto.ToLower() == "parar")
                            break;

                        Console.Write("qual a quantidade de itens? ");
                        quant = int.Parse(Console.ReadLine());

                        Console.Write("Digite o preço da compra: ");
                        precoCompra = decimal.Parse(Console.ReadLine());

                        decimal totalInvestido = quant * precoCompra;

                        if (totalInvestido > MInv)
                        {
                            MInv = totalInvestido;
                            NomeProdutoMaisInvestido = produto;
                        }

                        if (totalInvestido < menorInvestimento)
                        {
                            menorInvestimento = totalInvestido;
                            nomeProdutoMenosInvestido = produto;
                        }
                    }

                    Console.WriteLine("Maior quantia total investida:");
                    Console.WriteLine("Nome do produto: " + NomeProdutoMaisInvestido);
                    Console.WriteLine("Valor total investido: " + MInv);

                    Console.WriteLine("Menor quantia total investida:");
                    Console.WriteLine("Nome do produto: " + nomeProdutoMenosInvestido);
                    Console.WriteLine("Valor total investido: " + menorInvestimento);

                    break;


                case 3:

                    Console.WriteLine("Digite o número de avaliações que você planeja oferecer em um bimestre:");
                    int nummAv = int.Parse(Console.ReadLine());

                    double somaPesos = 0;
                    int contador = 0;

                    while (contador < nummAv)
                    {
                        Console.WriteLine("qual o peso de sua avaliação? " + (contador + 1) + ":");
                        double peso = double.Parse(Console.ReadLine());
                        somaPesos += peso;
                        contador++;
                    }

                    Console.WriteLine("Soma total dos pesos: " + somaPesos);

                    if (somaPesos < 100)
                    {
                        Console.WriteLine("A soma de seus pesos é insuficiente.");
                        break;
                    }
                    else if (somaPesos > 100)
                    {
                        Console.WriteLine("A soma de seus pesos estão suficientes.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("A soma total dos pesos está correta.");


                        break;
                    }

                case 4:


                    string sigla;

                    Console.WriteLine("\nAM");
                    Console.WriteLine("AC");
                    Console.WriteLine("AL");
                    Console.WriteLine("AP");
                    Console.WriteLine("BA");
                    Console.WriteLine("CE");
                    Console.WriteLine("ES");
                    Console.WriteLine("GO");
                    Console.WriteLine("MA");
                    Console.WriteLine("MT");
                    Console.WriteLine("MS");
                    Console.WriteLine("MG");
                    Console.WriteLine("PA");
                    Console.WriteLine("PB");
                    Console.WriteLine("PR");
                    Console.WriteLine("PE");
                    Console.WriteLine("PI");
                    Console.WriteLine("RJ");
                    Console.WriteLine("RN");
                    Console.WriteLine("RS");
                    Console.WriteLine("RO");
                    Console.WriteLine("RR");
                    Console.WriteLine("SC");
                    Console.WriteLine("SE");
                    Console.WriteLine("TO");
                    Console.WriteLine("DF");

                    Console.WriteLine("\n Escolha uma dessas siglas:");
                    sigla = Console.ReadLine();

                    switch (sigla)
                    {
                        case "AM":
                            Console.WriteLine("Amazonas");
                            break;
                        case "AC":
                            Console.WriteLine("Acre");
                            break;
                        case "AL":
                            Console.WriteLine("Alagoas");
                            break;
                        case "AP":
                            Console.WriteLine("Amapa");
                            break;
                        case "BA":
                            Console.WriteLine("Bahia");
                            break;
                        case "CE":
                            Console.WriteLine("Ceara");
                            break;
                        case "ES":
                            Console.WriteLine("Espirito Santo ");
                            break;
                        case "GO":
                            Console.WriteLine("Goias");
                            break;
                        case "MA":
                            Console.WriteLine("Maranhao");
                            break;
                        case "MT":
                            Console.WriteLine("Mato Grosso");
                            break;
                        case "MS":
                            Console.WriteLine("Mato Grosso do sul");
                            break;
                        case "MG":
                            Console.WriteLine("Minas Gerais");
                            break;
                        case "PA":
                            Console.WriteLine("Paraiba");
                            break;
                        case "PR":
                            Console.WriteLine("Parana");
                            break;
                        case "PE":
                            Console.WriteLine("Pernambuco");
                            break;
                        case "PI":
                            Console.WriteLine("Piaui");
                            break;
                        case "RJ":
                            Console.WriteLine("Rio de Janeiro");
                            break;
                        case "RN":
                            Console.WriteLine("Rio Grande do Norte");
                            break;
                        case "RS":
                            Console.WriteLine("Rio Grande do Sul");
                            break;
                        case "RO":
                            Console.WriteLine("Rondonia");
                            break;
                        case "RR":
                            Console.WriteLine("Roraima");
                            break;
                        case "SC":
                            Console.WriteLine("Santa Catrina");
                            break;
                        case "SE":
                            Console.WriteLine("Sergipe");
                            break;
                        case "TO":
                            Console.WriteLine("Tocantins");
                            break;
                        case "DF":
                            Console.WriteLine("Distrito Federal");
                            break;
                        default:
                            Console.WriteLine("Siga invalida");
                            break;

                    }
                    break;

                case 5:
                    while (true)
                    {
                        Console.Write("digite um número de 1 a 12  ");
                        int mes = int.Parse(Console.ReadLine());

                        string estacao;

                        switch (mes)
                        {
                            case 12:
                            case 1:
                            case 2:
                                estacao = "Verão";
                                break;
                            case 3:
                            case 4:
                            case 5:
                                estacao = "Outono";
                                break;
                            case 6:
                            case 7:
                            case 8:
                                estacao = "Inverno";
                                break;
                            case 9:
                            case 10:
                            case 11:
                                estacao = "Primavera";
                                break;
                            default:
                                Console.WriteLine("Número inválido! Digite um valor de 1 a 12:");
                                Console.WriteLine();
                                continue;
                        }

                        if ((mes == 3 || mes == 9) && estacao == "Outono")
                        {
                            Console.Write("O mês que você selecionou é março ou setembro,ou seja, são meses de transição. Deseja considerar a estação como Primavera (P) ou Outono (O)? ");
                            string opcao = Console.ReadLine();

                            if (opcao.ToUpper() == "P")
                            {
                                estacao = "Primavera";
                            }
                            else if (opcao.ToUpper() == "O")
                            {
                                estacao = "Outono";
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida. Estação considerada: " + estacao);
                            }
                        }

                        Console.WriteLine("A estação correspondente ao mês é: " + estacao);
                        Console.WriteLine();
                    }

                case 6:

                    double altura, kg, imc;

                    Console.WriteLine("Digite sua altura (em metros): ");
                    altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite seu peso (em kilos): ");
                    kg = double.Parse(Console.ReadLine());

                    imc = kg / (altura * altura);

                    if (imc < 18.5)

                    {
                        Console.WriteLine("você está abaixo de seu peso ideal!");

                        break;
                    }

                    if (imc >= 18.5 && imc <= 24.9)

                    {
                        Console.WriteLine("você está no peso certo!");

                        break;
                    }

                    if (imc >= 25 && imc <= 29.9)

                    {
                        Console.WriteLine("você está acima do peso!");

                        break;
                    }

                    if (imc >= 30 && imc < 34.9)

                    {
                        Console.WriteLine("você está com obesidade de 1° grau");

                        break;
                    }

                    if (imc >= 35 && imc < 39.9)

                    {
                        Console.WriteLine("você está com obesidade de 2° graus");

                        break;
                    }

                    if (imc >= 40)

                    {

                        Console.WriteLine("você está com obesidade de 3° graus");

                        break;

                    }

                    break;


                case 7:

                    Console.Write("Digite um número (ele tem que ser positivo e inteiro!): ");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero <= 0)
                    {
                        Console.WriteLine("O número deve ser maior que zero.");
                        break ;
                    }
                    else
                    {
                        Console.WriteLine("Divisores de " + numero + ":");

                        for (int i = 1; i <= numero; i++)
                        {
                            if (numero % i == 0)
                            {
                                Console.WriteLine(i);

                                break;
                            }
                        }
                    }
                    break ;
            }
        }
    }
}

                 
           
