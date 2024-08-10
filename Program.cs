using System.Data.SqlTypes;
using c_.Models;

string opcao;
bool exibirMenu = true;
while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

         case "3":
            Console.WriteLine("Apagar cliente");
            break;

         case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
           // Environment.Exit(0);
            break;
        
        default:
            Console.WriteLine("Opção inválida");
    }
}
Console.WriteLine("O programa se encerrou");










/*int soma = 0, numero = 0;
do
{
    Console.WriteLine("Digite um número: (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
} while(numero != 0);

Console.WriteLine($"Total da soma dos numeros digitados é {soma}");
*/







/*
int numero = 5;
int contador = 0;
while (contador <= 10)
{
    Console.WriteLine($"{contador}  Execução:  {numero} x {contador} = {numero * contador}");
    contador++;
}
*/










/*int numero = 5;

for(int contador = 0; contador <= 10; contador++)
{
   Console.WriteLine($"{numero} x {contador} = {numero * contador}"); 
}
*/








/*Calculadora calc = new Calculadora();

int numeroIncremento = 10;
Console.WriteLine(numeroIncremento);
Console.WriteLine("Incrementação o 10");
numeroIncremento++;

int numeroDecremento = 20;
Console.WriteLine("Decrementando o 20");
numeroDecremento++;

Console.WriteLine(numeroDecremento);*/









//calc.Somar(10, 5);
//calc.Subtrair(10, 5);
//calc.Multiplicar(10, 5);
//calc.Dividir(10, 2);
//calc.Potencia(3, 3);
/*calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);*/











/*Pessoa p1 = new Pessoa();
p1.Nome = "Bruna";
p1.Idade = 17;
p1.Apresentar();*/









/*
Exempo de conversação de string para int:
String a = "15";
int b = 0;
int.TryParse(a, out b);
Console.WriteLine(b);*/