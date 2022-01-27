using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"C:\Users\Elizaveta\Desktop\учеба ИТМО";         
            

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги");
                string[] dirs = Directory.GetDirectories(dirName);
                int lengthD = dirs.Length;
                
                for (int i = 0; i < lengthD; i++)
                {
                    
                   
                    if (Directory.Exists(dirs[i]))
                    {
                        string[] files = Directory.GetFiles(dirs[i]);
                        int lengthF = files.Length;                        
                        foreach (string s in files)
                        {
                            
                            Console.WriteLine(s);
                        }
                    }

                    
                        
                    
                }
                

            }Console.ReadKey();
        }
        
    }
}
