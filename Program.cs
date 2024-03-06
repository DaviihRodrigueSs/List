using System.Globalization;
using System.Collections.Generic;
namespace List
{
    class program
    {
        //utilizando o list 
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Alessandra");
            list.Add("Davi");
            list.Add("Helena");
            list.Add("Ana");
            list.Add("Mayra");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'D');

            Console.WriteLine("First 'D': " + s1);

            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("Last 'M': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A' " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A'" + pos2);

            //apenas os nomes que tem 5 caracteres.

            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("___________________");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            // remover apenas o marco
            list.Remove("Marco");
            Console.WriteLine("___________________");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);


            }
            // remover todos os nomes com as iniciais A

            list.RemoveAll(x => x[0] == 'A');
            Console.WriteLine("______________________________");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);


            }


            //para remover um usuario vc deve usar o comando list.RemoveAt

            //Para remover a partir de uma função usar o comando list.RemoveRange
       

        }
    }
}