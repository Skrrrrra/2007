using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace roundnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputpath = "D:\\SolutionsForSpaceApp\\2007\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2007\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            int count = Convert.ToInt32(File.ReadAllText(inputpath));


            int maxPower= Convert.ToInt32(Math.Log(count & - count, 2));

            File.WriteAllText(outputpath, maxPower.ToString());
            

        }
    }
}
