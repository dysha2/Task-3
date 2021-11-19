using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = File.ReadAllText("input.txt").Split(" ");
            if (line[0]=="")
            {
                File.WriteAllText("output.txt", "0");
            } else
            {
                int Words = 0;
                for (int i=0;i<line.Length;i++)
                {
                    if (line[i][0]=='0')
                    {
                        ++Words;
                    } else
                    {
                        int counter = 1;
                        while(line[i][counter]!='0')
                        {
                            ++counter;
                        }
                        ++Words;
                        i += counter;
                    }
                }
                File.WriteAllText("output.txt", Words.ToString());
            }
        }
    }
}
