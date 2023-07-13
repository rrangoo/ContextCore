using System;
using CoreContext;
using CoreContext.material;
using CoreContext.texture;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Scene scene = new Scene();
            scene.Load();
            scene.Show();
            Console.ReadKey();
        }
    }
}