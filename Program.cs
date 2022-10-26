using ControleDeAnimais;
using static ControleDeAnimais.Animal;


Animal animal1 = new Animal();

int totalCachorro = 0, totalGato = 0, totalPeixe = 0;
int tipoAnimal = 0;

Console.WriteLine("Controle de animais");


// Primeiro animal
Console.Write("Informe o nome do 1º animal: ");
animal1.Nome = Console.ReadLine();
Console.Write("Informe o tipo do 1º animal (Cachorro - 0, Gato - 1, Peixe - 2): ");

try
{
    tipoAnimal = Convert.ToInt32(Console.ReadLine());
    if (tipoAnimal < 0) tipoAnimal = 2;
    if (tipoAnimal > 2) tipoAnimal = 2;
}
catch
{
    tipoAnimal = 2;
}

// if (tipoAnimal == 0) animal1.Tipo = TipoAnimal.Cachorro;
// if (tipoAnimal == 1) animal1.Tipo = TipoAnimal.Gato;
// if (tipoAnimal == 2) animal1.Tipo = TipoAnimal.Peixe;

// Tipo informado pelo usuário
animal1.Tipo = (TipoAnimal)tipoAnimal;

// Contando o tipo informado
if (animal1.Tipo == TipoAnimal.Cachorro) totalCachorro++;
if (animal1.Tipo == TipoAnimal.Gato) totalGato++;
if (animal1.Tipo == TipoAnimal.Peixe) totalPeixe++;

// Resultado
System.Console.WriteLine("Total de animais");
Console.WriteLine($"Cachorros: {totalCachorro} \nGatos: {totalGato} \nPeixes : {totalPeixe}");