using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    internal class DataManipulation
    {
        private string filepath = "C:\\Users\\ja\\source\\repos\\ConsoleApp1\\ConsoleApp1\\DataStorage\\";
        public void Add()
        {

        }
        public void Remove(string type, string name)
        {
            switch(type)
            {
                case "f":
                    FileInfo fi = new FileInfo(filepath);
                    DirectoryInfo di = fi.Directory;
                    foreach (FileInfo file in di.GetFiles())
                    {
                        if(file.Name == name)
                        {
                            file.Delete();
                        }
                    }
                    break;
                case "i":
                    break;
                case "n":
                    break;
                default:
                    Console.WriteLine($"Uknown remove type: \"{type}\"");
                    break;
            }  
        }
        public void Update()
        {

        }
        public void Show_Data(string type)
        {
            switch(type)
            {
                case "l":
                    FileInfo fi = new FileInfo(filepath);
                    DirectoryInfo di = fi.Directory;
                    FileInfo[] files = di.GetFiles();
                    foreach(FileInfo x in files)
                    {
                        Console.WriteLine(x);
                    }
                    break;
                default:
                    Console.WriteLine($"Uknown show type: \"{type}\"");
                    break;
            }
           
        }
        public void Sort_Data()
        {

        }
        public void Create(string type,string name)
        {
            switch (type)
            {
                case "c":
                    filepath += $"{name}.csv"; 
                    using (StreamWriter writer = new StreamWriter(new FileStream(filepath,
                    FileMode.Create)))
                    
                    break;
                case "x":
                    filepath += $"{name}.xml";
                    using (StreamWriter writer = new StreamWriter(new FileStream(filepath,
                    FileMode.Create)))
                        break;
                case "j":
                    filepath += $"{name}.json";
                    using (StreamWriter writer = new StreamWriter(new FileStream(filepath,
                    FileMode.Create)))
                        break;
                default:
                    Console.WriteLine($"Uknown create type: \"{type}\"");
                    break;

            }
        }
        public void Open_File()
        {

        }
        public void Help()
        {
            Console.WriteLine(@"-------------------------------------------------------------------------------
                    command: create
                            -c [name]   creates csv file
                            -x [name]  creates xml file
                            -j [name]  creates json file
                    command: rem
                            -f [name] removes file
                            -i [objectid] removes object with specified id
                            -n [objectname] removes objects with specified name (removes everything)
                    command: shwdat 
                            -l        lists all datafiles
                            -t [typeofile] to list all files with certain type

                    command: openfile [nameoffile]
                            opens specified datafile
                            
                    ");   
        }
    }
}
