using System;
using System.Collections;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op=0;
            double preco;
            int quantMelanciasBaby = 0;
            int quantMelanciasComun = 0;
            double precoTotalComun = 0;
            double precoTotalBaby = 0;
            double precototalgeral = 0;
            double quantidadetotalgeral = 0;




            string PlacaCaminhao= " Não Cadastrada";
            string Motorista= " Não Cadastrado";
            

            int PesoMelancia = 0;
            int PesoMelanciaBaby = 0;

            String loginCerto = "senai";
            String senhaCerto = "senai123";
            String login;
            String senha;
            
            int contLogin = 3;

            do
            {
                Console.WriteLine("Digite seu login:");
                login = Console.ReadLine();
                Console.WriteLine("Digite sua senha:");
                senha = Console.ReadLine();

                
                if (login != loginCerto || senha != senhaCerto)
                {
                    contLogin--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Senha incorreta! Você tem mais {contLogin} tentativas.");
                    Console.ResetColor();
                    if (contLogin == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Você excedeu o número de tentativas, entre em contato com o administrador");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                    }
                        
              
                }

                else if (login == loginCerto && senha == senhaCerto)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns você está com acesso ao sistema!");
                    Console.ResetColor();


                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("---MENU DO MELANCIOMETRO---");
                        Console.ResetColor();
                        Console.WriteLine("1- Melancia Comum \n2- Melancia Baby \n3- Cadastrar Placa do Caminhão\n4- Cadastrar Motorista\n5- Calcular Desconto\n6- Sair");
                        op = int.Parse(Console.ReadLine());




                        if (op == 1)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Digite o Peso da Melancia Comun");
                            Console.ResetColor();

                            PesoMelancia = int.Parse(Console.ReadLine());
                            preco = 5.50;
                            Console.WriteLine("Melancia Comum: " + preco.ToString("F2"));

                            quantMelanciasComun++;
                            precoTotalComun += preco * PesoMelancia;
                            precototalgeral = precoTotalBaby + precoTotalComun;
                            quantidadetotalgeral = quantMelanciasBaby + quantMelanciasComun;

                            Console.WriteLine($"Melancia Comum Quantidade: {quantMelanciasComun}. Preço total Melancia Comun: {precoTotalComun.ToString("F2")}\n");

                            Console.WriteLine($"Preço total adicionado ao carrinho: {precototalgeral.ToString("F2")}");
                            Console.WriteLine($"Quantidade de melancias adicionadas ao Carrinho: {quantidadetotalgeral.ToString("F2")}\n");

                            Console.WriteLine($"Placa do Caminhão:{PlacaCaminhao}");
                            Console.WriteLine($"Nome do Motorista:{Motorista}");
                            Console.WriteLine("Precione qualquer tecla para continuar");
                            //Console.ReadLine();
                            Console.ReadKey(); ;
                            Console.Clear();

                        }
                        else if (op == 2)
                        {


                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Digite o Peso da Melancia Baby");
                            Console.ResetColor();

                            PesoMelanciaBaby = int.Parse(Console.ReadLine());
                            preco = 8.56;
                            Console.WriteLine("Melancia Baby: " + preco.ToString("F2"));


                            quantMelanciasBaby++;
                            precoTotalBaby += preco * PesoMelanciaBaby;
                            quantidadetotalgeral = quantMelanciasBaby + quantMelanciasComun;
                            
                            Console.WriteLine($"Melancia Baby Quantidade: {quantMelanciasBaby}. Preço total: {precoTotalBaby.ToString("F2")}");
                            double precogeral = precoTotalBaby + precoTotalComun;
                            
                            Console.WriteLine($"Preço total adicionado ao carrinho: {precototalgeral.ToString("F2")}");
                            Console.WriteLine($"Quantidade de melancias adicionadas ao Carrinho: {quantidadetotalgeral.ToString("F2")}\n");
                            
                            Console.WriteLine($"Placa do Caminhão:{PlacaCaminhao}");
                            Console.WriteLine($"Nome do Motorista:{Motorista}\n");
                            Console.WriteLine("Precione qualquer tecla para continuar");
                            Console.ReadKey(); ;
                            Console.Clear();
                        }
                        if (op == 3)
                        {

                            Console.WriteLine("Digite a placa do caminhão:");
                            PlacaCaminhao = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Placa do Caminhão:{PlacaCaminhao}");
                            Console.WriteLine("Placa do Caminhão cadastrado com sucesso!");
                            Console.ResetColor();
                            Console.WriteLine("Precione alguma tecla para contituar");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else if (op == 4)
                        {

                            Console.WriteLine("Digite o Nome do Motorista:");
                            Motorista = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Motorista cadastrado com sucesso");
                            Console.ResetColor();
                            Console.WriteLine($"Nome do Motorista:{Motorista}");
                            Console.WriteLine("Precione qualquer tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();




                        }
                        if (op == 5)
                        {
                            int diadasemana = 0;
                            double descontovalordacompra = 0;

                            Console.WriteLine("Digite um da semana");
                            Console.WriteLine(" 1 - Segunda-Feira \n 2 - Terça-Feira \n 3 - Quarta-Feira \n 4 - Quinta-Feira \n 5 - Sexta-Feira\n");
                            diadasemana = int.Parse(Console.ReadLine());

                            switch (diadasemana)

                            {
                                case 1:

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine($"Preço total adicionado ao carrinho:  {precototalgeral.ToString("F2")}");
                                    Console.WriteLine($"Quantidade de melancias adicionadas ao Carrinho:  {quantidadetotalgeral.ToString("F2")}\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine($"Placa do Caminhão:{PlacaCaminhao}");
                                    Console.WriteLine($"Nome do Motorista:{Motorista}\n");
                                    Console.ResetColor();

                                    Console.WriteLine("Qual o valor da compra?");
                                    descontovalordacompra = double.Parse(Console.ReadLine());
                                    descontovalordacompra = descontovalordacompra - (descontovalordacompra * 0.1);
                                    Console.WriteLine($"O valor total da sua compra: {descontovalordacompra} e com desconto: {descontovalordacompra - (descontovalordacompra * 0.0)}");
                                    Console.WriteLine("Precione 'Enter' para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case 2:

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine($"Preço total adicionado ao carrinho:  {precototalgeral.ToString("F2")}");
                                    Console.WriteLine($"Quantidade de melancias adicionadas ao Carrinho:  {quantidadetotalgeral.ToString("F2")}\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine($"Placa do Caminhão:{PlacaCaminhao}");
                                    Console.WriteLine($"Nome do Motorista:{Motorista}\n");
                                    Console.ResetColor();

                                    Console.WriteLine("Qual o valor da compra?");
                                    descontovalordacompra = double.Parse(Console.ReadLine());
                                    descontovalordacompra = descontovalordacompra - (descontovalordacompra * 0.1);
                                    Console.WriteLine($"O valor total da sua compra: {descontovalordacompra} e com desconto: {descontovalordacompra - (descontovalordacompra * 0.15)}");
                                    Console.WriteLine("Precione 'Enter' para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case 3:

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine($"Preço total adicionado ao carrinho:  {precototalgeral.ToString("F2")}");
                                    Console.WriteLine($"Quantidade de melancias adicionadas ao Carrinho:  {quantidadetotalgeral.ToString("F2")}\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine($"Placa do Caminhão:{PlacaCaminhao}");
                                    Console.WriteLine($"Nome do Motorista:{Motorista}\n");
                                    Console.ResetColor();

                                    Console.WriteLine("Qual o valor da compra?");
                                    descontovalordacompra = double.Parse(Console.ReadLine());
                                    descontovalordacompra = descontovalordacompra - (descontovalordacompra * 0.1);
                                    Console.WriteLine($"O valor total da sua compra: {descontovalordacompra} e com desconto: {descontovalordacompra - (descontovalordacompra * 0.17)}");
                                    Console.WriteLine("Precione 'Enter' para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case 4:

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine($"Preço total adicionado ao carrinho:  {precototalgeral.ToString("F2")}");
                                    Console.WriteLine($"Quantidade de melancias adicionadas ao Carrinho:  {quantidadetotalgeral.ToString("F2")}\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine($"Placa do Caminhão:{PlacaCaminhao}");
                                    Console.WriteLine($"Nome do Motorista:{Motorista}\n");
                                    Console.ResetColor();

                                    Console.WriteLine("Qual o valor da compra?");
                                    descontovalordacompra = double.Parse(Console.ReadLine());
                                    descontovalordacompra = descontovalordacompra - (descontovalordacompra * 0.1);
                                    Console.WriteLine($"O valor total da sua compra: {descontovalordacompra} e com desconto: {descontovalordacompra - (descontovalordacompra * 0.2)}");
                                    Console.WriteLine("Precione 'Enter' para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case 5:

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine($"Preço total adicionado ao carrinho:  {precototalgeral.ToString("F2")}");
                                    Console.WriteLine($"Quantidade de melancias adicionadas ao Carrinho:  {quantidadetotalgeral.ToString("F2")}\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine($"Placa do Caminhão:{PlacaCaminhao}");
                                    Console.WriteLine($"Nome do Motorista:{Motorista}\n");
                                    Console.ResetColor();

                                    Console.WriteLine("Qual o valor da compra?");
                                    descontovalordacompra = double.Parse(Console.ReadLine());
                                    descontovalordacompra = descontovalordacompra - (descontovalordacompra * 0.1);
                                    Console.WriteLine($"O valor total da sua compra: {descontovalordacompra} e com desconto: {descontovalordacompra - (descontovalordacompra * 0.3)}");
                                    Console.WriteLine("Precione 'Enter' para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;


                            }








                        }
                        else if (op == 6)
                        {

                            Console.WriteLine("AGRADECEMOS A PREFERÊNCIA!!");
                            Console.WriteLine("");
                            Console.WriteLine("─▄▀─▄▀");
                            Console.WriteLine("──▀──▀");
                            Console.WriteLine("█▀▀▀▀▀█▄");
                            Console.WriteLine("█░░░░░█─█");
                            Console.WriteLine("▀▄▄▄▄▄▀▀");
                            Console.WriteLine("");
                            Console.WriteLine("PRECIONE QUALQUER TECLA PARA SAIR");
                            Console.ReadKey();
                            break;


                        }



                        else
                        {

                        }


                        //Console.WriteLine("Pressione 'Enter' para continuar ou '0' para sair.");

                    } while (op != 6); //while (Console.ReadKey().KeyChar != '0');
                    break;
                }

                
            } while (op != 6);


        }
    }
}



