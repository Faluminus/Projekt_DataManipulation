using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DataManipulation
    {
        public void Add()
        {

        }
        public void Remove()
        {

        }
        public void Update()
        {

        }
        public void Show_Data()
        {

        }
        public void Sort_Data()
        {

        }
        public void Create(string type)
        {
            string FilePath = "C:\\Users\\ja\\source\\repos\\ConsoleApp1\\ConsoleApp1\\DataStorage\\";
            switch(type)
            {
                case "-c":
                    FileStream fs = File.Create(FilePath);
                    break;
                case "-x":
                    
                    break;
                case "-j":

                    break;
                default:
                    Console.WriteLine($"Uknown type: {type}");
                    break;

            }
        }
        public void Select()
        {

        }
        public void Help()
        {
            Console.WriteLine(@"-------------------------------------------------------------------------------
                    command: create
                            -c   creates csv file
                            -x   creates xml file
                            -j   creates json file

                    command: showdata 
                            -l        lists all datafiles

                    command: openfile [nameoffile]
                            opens specified datafile
                            
                    ");   
        }
    }
}
