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
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataManipulation dataManipulation = new DataManipulation();
            Is_Dir_Empty("C:\\Users\\ja\\source\\repos\\ConsoleApp1\\ConsoleApp1\\DataStorage\\");
            while (true)
            {
                Text_Color("blue", $"User/{Currently_Editing()}:",false);
                string input = Console.ReadLine();
                List<string> commands = new List<string>(Command_Split(input));
                try
                {
                    switch (commands[0])
                    {
                        case "help":
                            dataManipulation.Help();
                            break;
                        case "create":
                            dataManipulation.Create(commands[1], commands[2]);
                            Text_Color("green","Done",true);
                            break;
                        case "open":
                            dataManipulation.Open_File();
                            break;
                        case "shwdat":
                            dataManipulation.Show_Data(commands[1]);
                            break;
                        case "rem":
                            dataManipulation.Remove(commands[1], commands[2]);
                            Text_Color("green", "Done", true);
                            break;
                        case "cl":
                            Console.Clear();
                            break;
                        case "exit":
                            Environment.Exit(0);
                            break;
                        default:
                            Text_Color("red", $"Uknown command \"{commands[0]}\"", true);
                            break;
                    }
                }
                catch(Exception)
                {
                    Text_Color("red", "Wrong syntax (use \"-\" after every command)",true);
                }
            }
        }
        private static List<string> Command_Split(string input)
        {
            List<string> commands = new List<string>();
            string singlecommand = "";
            foreach (char splitedinput in input)
            {
                switch(splitedinput)
                {
                    case '-':
                        commands.Add(singlecommand);
                        singlecommand = "";
                        break;
                    case ' ':
                        break;
                    default:
                        singlecommand = singlecommand + splitedinput;
                        break;

                }
            }
            return commands;
        }
        private static void Is_Dir_Empty(string directory)
        {
            if (Directory.GetFiles(directory).Count() == 0)
            {
                Console.WriteLine("Reminder!!!! the data file must be inserted into DataStorage folder or created by proper command (do help- for getting all cmds) !!!");
            }
        }
        private static string Currently_Editing()
        {
            string file = "";
            return file;
        }
        //text_color function colors text and writes to console
        private static void Text_Color(string color, string text, bool withline)//"withline" for decision if you want writeline or just write
        {
            switch (color)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
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
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
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
                    Console.ForegroundColor = ConsoleColor.Blue;
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
                }
        
            }
        }
    }  