using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProjCharGenerator
{
    public class GenericGeneration
    {
        public string[] data;
        public int size;
        public int[] weights;
        public int[] upBorder;
        public int weightsSum = 0;
        string type;

        public GenericGeneration(string inputType)
        {
            type = inputType;
            string buf = File.ReadAllText("../../../../ProjCharGenerator/" + type + "Data.txt");
            data = buf.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            size = data.Length;
            weights = new int[size * size];
            upBorder = new int[size * size];

            string[] weightsBuf = File.ReadAllText("../../../../ProjCharGenerator/" + type + "Weights.txt").Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < weightsBuf.Length; i++)
                weights[i] = int.Parse(weightsBuf[i]);
            for (int i = 0; i < size * size; i++)
            {
                weightsSum += weights[i];
                upBorder[i] = weightsSum;
            }
        }

        public string Generate()
        {
            Random random = new Random();
            int val = random.Next(0, weightsSum);

            if (type == "Bigramm")
            {
                for (int i = 0; i < size * size; i++)
                    if (upBorder[i / size * size + i % size] > val)
                        return data[i / size].ToString() + data[i % size];
                return data[size - 1] + data[size - 1];
            }

            for (int i = 0; i < size; i++)
                if (upBorder[i] > val)
                    return data[i];
            return data[size - 1];
        }
    }
}
