using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataManipulation dataManipulation = new DataManipulation();
            string file = "";
            if (Directory.GetFiles("C:\\ConsoleApp1\\ConsoleApp1\\DataStorage\\").Count() == 0)
            {
                Console.WriteLine("Reminder!!!! the data file must be inserted into DataStorage folder or created by proper command (do --help for getting all cmds) !!!");
            }
            while (true)
            {
                Text_Color("blue", $"User/{file}:",false);
                string input = Console.ReadLine();
                switch(input.ToLower())
                {
                    case "--help":
                        dataManipulation.Help();
                        break;
                    case "create":
                        Text_Color("green", "Type/:",false);
                        input = Console.ReadLine();
                        dataManipulation.Create(input);
                        
                        break;
                    case "cl":
                        Console.Clear();
                        break;
                    default:
                        Text_Color("red","Uknow command",true);
                        break;
                }
            }
        }
        //text_color function colors text and writes to console
        private static void Text_Color(string color, string text,bool withline )//"withline" for decision if you want writeline or just write
        {
            switch(color)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    switch(withline)
                    {
                        case true:
                            Console.WriteLine(text);
                            break;
                        case false:
                            Console.Write(text);
                            break;
                    }
                    Console.ResetColor();

                    break;
                case "green":
                    Console.ForegroundColor= ConsoleColor.Green;
                    switch (withline)
                    {
                        case true:
                            Console.WriteLine(text);
                            break;
                        case false:
                            Console.Write(text);
                            break;
                    }
                    Console.ResetColor();
                    break;
                case "blue":
                    Console.ForegroundColor= ConsoleColor.Blue;
                    switch (withline)
                    {
                        case true:
                            Console.WriteLine(text);
                            break;
                        case false:
                            Console.Write(text);
                            break;
                    }
                    Console.ResetColor ();
                    break;
            }
        }
    }
}