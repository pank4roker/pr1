using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросить через констоль имя пользователся, затем поздороваться с ним.
            //Изменить цыет фона и символов.
            //Установить название в соответствии с именем пользователя.
            //Отоброжать, включен ли CapsLock b NumLock
            SetWindowSize(50, 50);
            BackgroundColor = ConsoleColor.DarkBlue;
            Clear();
            ForegroundColor = ConsoleColor.White;
            WriteLine("Как тебя зовут?");
            string name = ReadLine();
            WriteLine($"Привет, {name} !");
            Title = name;
            CursorVisible = false;
            WriteLine("Caps LOck - " + (CapsLock ? "On": "Off"));
            WriteLine("Namber LOck - " + (NumberLock ? "On" : "Off"));
            ReadKey();





        }
    }
}
