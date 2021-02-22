using System;

namespace ProjetoNET1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();//chamando a classe pra fazer as funcoes
            double a = 0;
            double b = 0;
        
            Console.Write("~~~~~~~~~~~~~~**BEM VINDO A MINHA CALCULADORA!**~~~~~~~~~~~\n");
            Console.Write("|-------------------------OPCOES--------------------------|\n");
            Console.Write("|1. SOMA || 2. SUBTRACAO || 3. DIVISAO || 4. MULTIPLICACAO|\n");
            Console.Write("OPCAO: ");
            bool finalizarApp = false;//pra rodar e fechar o app
            var opcao = Convert.ToInt32(Console.ReadLine());
            string opcaoSair;

            while(!finalizarApp){
                try{
                    switch(opcao){//faltando manejar exceção por input string de formato(se digitar letra ouves de num)
                        case 1:
                            Console.Write("Digite um numero: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite outro numero: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {calc.somar(a, b)}");
                            Console.WriteLine("Sair [S] || Qualquer outra letra para continuar...");
                            opcaoSair = Console.ReadLine();
                            if(opcaoSair== "S" || opcaoSair== "s"){ finalizarApp = true; }
                            break;
                        case 2:
                            Console.Write("Digite um numero: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite outro numero: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {calc.subtrair(a, b)}");
                            Console.WriteLine("Sair [S] || Qualquer outra letra para continuar...");
                            opcaoSair = Console.ReadLine();
                            if(opcaoSair== "S" || opcaoSair== "s"){ finalizarApp = true; }
                            break;
                        case 3:
                            Console.Write("Digite um numero: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite um numero nao-nulo: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            while(b == 0){
                                Console.Write("Digite um numero nao-nulo: ");
                                b = Convert.ToDouble(Console.ReadLine());
                            }//nao permite dividir 0 por 0, por ora ta bom
                            Console.WriteLine($"Resultado: {calc.dividir(a, b)}");
                            Console.WriteLine("Sair [S] || Qualquer outra letra para continuar...");
                            opcaoSair = Console.ReadLine();
                            if(opcaoSair== "S" || opcaoSair== "s"){ finalizarApp = true; }
                            break;
                        case 4:
                            Console.Write("Digite um numero: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite outro numero: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {calc.multiplicar(a, b)}");
                            Console.WriteLine("Sair [S] || Qualquer outra letra para continuar...");
                            opcaoSair = Console.ReadLine();
                            if(opcaoSair== "S" || opcaoSair== "s"){ finalizarApp = true; }
                            break;
                        default:
                            Console.WriteLine("Favor escolher uma opcao valida!");
                            finalizarApp = true;
                            break;
                    }
                }catch(Exception e){
                    Console.WriteLine("Algo deu errado! Detalhes: " + e.Message);
                }
           }
        }
    }
}

