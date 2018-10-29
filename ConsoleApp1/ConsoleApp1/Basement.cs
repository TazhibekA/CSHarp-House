using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Basement : IPart
    {
        public string MaterialName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public static int count = 0;
        public Basement(string materialName, int width, int height, int cost)
        {
            MaterialName = materialName;
            Width = width;
            Height = height;
            Cost = cost;
            count++;
        }
    }
}
