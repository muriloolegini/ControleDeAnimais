using ControleDeAnimais;
using static ControleDeAnimais.Animal;


Animal animal;
int quantidade = 0;

// Array
Animal[] animais = new Animal[30];

int totalCachorro = 0, totalGato = 0, totalPeixe = 0;
int tipoAnimal = 0;

Console.WriteLine("Controle de animais");

// Leitura da quantidade de animais
try
{
    Console.WriteLine("Quantos animais deseja informar (máximo 30): ");
    quantidade = Convert.ToInt32(Console.ReadLine());

    if (quantidade > 20) quantidade = 20;
}
catch
{
    quantidade = 0;
}

for (int i = 0; i < quantidade; i++)
{
    // Leitura do animal
    animal = new Animal();
    Console.Write($"Informe o nome do {i + 1}º animal: ");
    animal.Nome = Console.ReadLine();
    Console.Write($"Informe o tipo do {i + 1}º animal (Cachorro - 0, Gato - 1, Peixe - 2): ");

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

    animal.Tipo = (TipoAnimal)tipoAnimal;
    // Contando o tipo informado
    if (animal.Tipo == TipoAnimal.Cachorro) totalCachorro++;
    if (animal.Tipo == TipoAnimal.Gato) totalGato++;
    if (animal.Tipo == TipoAnimal.Peixe) totalPeixe++;

    // Armazenar animal no vetor
    animais[i] = animal;
}


// Resultado
System.Console.WriteLine("Total de animais");
Console.WriteLine($"Cachorros: {totalCachorro} \nGatos: {totalGato} \nPeixes : {totalPeixe}");