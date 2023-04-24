using System;
using System.Collections.Generic;
using System.IO;

namespace ProjCharGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ToFile(new GenericGeneration("Bigramm"), "Bigramm.txt");
            ToFile(new GenericGeneration("Text"), "Text.txt");
            ToFile(new GenericGeneration("PairWord"), "PairWordText.txt");
        }

        public static void ToFile(GenericGeneration generator, string path, int count = 1000)
        {
            string buf = "";
            for (int i = 0; i < count; i++)
                buf += generator.Generate() + " ";
            File.WriteAllText(path, buf);
        }
    }
}

