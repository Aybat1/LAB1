using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string file = @"c:/";
                Provodnik(file);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
          public static void Provodnik(string path)
        {
            Console.Clear();
            DirectoryInfo d = new DirectoryInfo(path);

            List<FileSystemInfo> FSI = new List<FileSystemInfo>();
            FSI.AddRange(d.GetDirectories());
            FSI.AddRange(d.GetFiles());
            int index = 0;
            while (true)
            {
                for(int i = 0; i < FSI.Count; i++)
                {
                    if (index == i)
                    {
                        Console.BackgroundColor=ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.WriteLine(FSI[i].Name);
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                ConsoleKeyInfo button = Console.ReadKey();
                switch (button.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < FSI.Count - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        if (FSI[index].GetType() == typeof(DirectoryInfo))
                        {
                            path = FSI[index].FullName;
                            Provodnik(path);
                            FSI.Clear();
                        }
                        else if (FSI[index].GetType() == typeof(FileInfo))
                        {
                            FileStream fs = new FileStream(FSI[index].FullName, FileMode.Open, FileAccess.Read);
                            StreamReader sr = new StreamReader(fs);
                            string readfile = sr.ReadToEnd();
                            Console.Clear();
                            Console.WriteLine(readfile);
                        }
                        break;
                    case ConsoleKey.Escape:
                        int Count = 0;
                        for(int i = path.Length - 2; i >= 0; i--)
                        {
                            if (Convert.ToInt32(path[i]) == 92)
                                break;
                            else{
                                Count++;
                            }
                        }
                        path = path.Remove(path.Length - Count - 1);
                        Provodnik(path);
                        break;

                }
                Console.Clear();
            }
        }
        }
    }