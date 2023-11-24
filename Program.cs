int numero = 0;

Console.WriteLine
    ("--- Entrada Válida ---");

do
{
    Console.Write
        ("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
    Console.ReadLine();
}
while (numero < 0);

if (numero == 0)
{
    Console.WriteLine("Operação Cancelada.\nVolte Sempre!");
}