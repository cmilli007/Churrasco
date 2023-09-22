// See https://aka.ms/new-console-template for more information
Console.WriteLine("Churrasco");
int adultosCAlcool, adultosSAlcool, criancas, adultos, pessoas;
double carne, acompanhamentos, cerveja, refrigerante, agua;


Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
adultosCAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
adultosSAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Crianças: ");
criancas = Convert.ToInt32(Console.ReadLine());

adultos = adultosCAlcool + adultosSAlcool;
pessoas = adultos + criancas;

carne = 0.4 * adultos + 0.2 * criancas;
acompanhamentos = 0.2 * pessoas;
cerveja = 2 * adultosCAlcool;
refrigerante = 0.5 * (adultosSAlcool + criancas);
agua = 0.4 * pessoas;

Console.WriteLine();

Console.WriteLine($"Carne.............: {carne:N1}kg");
Console.WriteLine($"Acompanhamentos...: {acompanhamentos:N1}kg");
Console.WriteLine($"Cerveja...........: {cerveja:N1}l");
Console.WriteLine($"Refrigerante......: {refrigerante:N1}l");
Console.WriteLine($"Água..............: {agua:N1}l");
