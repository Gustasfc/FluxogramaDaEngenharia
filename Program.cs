bool objetoEstaSeMovendo;
bool objetoDeveriaMover;
string mensagem;

Console.Clear();

Console.WriteLine("*--- Fluxograma da Engenharia ---*");
Console.WriteLine("O objeto está se movendo (Digite 's' para sim ou 'n' para não)?");
objetoEstaSeMovendo = Console.ReadLine()! == "s"; 

Console.WriteLine("Ele deveria estar se movendo (Digite 's' para sim ou 'n' para não)?");
objetoDeveriaMover = Console.ReadLine()! == "s";

if (!objetoEstaSeMovendo)
{
    if (!objetoDeveriaMover)
    {
        mensagem = "Ótimo!";
        Console.WriteLine(mensagem);
    }
    else
    {
        mensagem = "Use WD-40!";
        Console.WriteLine(mensagem);
    }
}
else
{
    if (!objetoDeveriaMover)
    {
        mensagem = "Use Silver Tape!";
        Console.WriteLine(mensagem);
    }
    else
    {
        mensagem = "Ótimo!";
        Console.WriteLine(mensagem);
    }
}
