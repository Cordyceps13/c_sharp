using System;
class  Program{
    public static int Main(string[] args){
        DateTime date = DateTime.Now;
        Console.WriteLine($"Data atual: {date}");
        string nome = "André Proença";
        Console.WriteLine($"Autor: {nome}");
        int primVar = 1;
        Console.WriteLine($"Primeira variável = {primVar}");

        return 0;
    }
}
