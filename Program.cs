using System;
using static System.Console;
using Prj_Rpg_Csharp.src.Entities;

namespace Prj_Rpg_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "white wizard");

            WriteLine("");
            WriteLine("--- Personagem ---");
            WriteLine("");
            WriteLine("Player 1");
            WriteLine($" Nome: {arus.Name} level- {arus.Level}lv  - Heroi: {arus.Herotype}");
            WriteLine("");
            WriteLine("Player 2");
            WriteLine($" Nome: {wizard.Name} level- {wizard.Level}lv  - Heroi: {wizard.Herotype}");
            WriteLine("");
            WriteLine(arus.Attack(4));
            WriteLine(arus.Attack(10));
            WriteLine("");
            WriteLine(wizard.Attack(4));
            WriteLine(wizard.Attack(24));
        }
    }
}
