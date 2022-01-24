using System;
using System.Collections.Generic;

namespace SuperConstructor_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class2 class2 = new Class2("Kiran");



            // Generics Classes (Primitive)

            Class3<string> class3 = new Class3<string>();
            class3.Add("Kiran");
            class3.Add("Kiran1");

            foreach (var item in class3.list2)
            {
                Console.WriteLine(item);
            }

            Class3<int> class33 = new Class3<int>();
            class33.Add(1);
            class33.Add(2);

            foreach (var item in class33.list2)
            {
                Console.WriteLine(item);
            }


            // Generics Classes (Primitive with two parameters)

            Class4<int, int> class4 = new Class4<int, int>();

            class4.Dictionary.Add(1, 2);
            class4.Dictionary.Add(2, 4);
            class4.Dictionary.Add(3, 6);


            Class4<int, string> class41 = new Class4<int, string>();

            class41.Dictionary.Add(1, "Kiran");
            class41.Dictionary.Add(2, "Kiran-1");
            class41.Dictionary.Add(3, "Kiran-2");



            // Generics Classes (Reference type - class)

            Class3<Class5> class5 = new Class3<Class5>();

            class5.list2.Add(new Class5 { Address = "as", Id = 1, Name = "Kiran" });
            class5.list2.Add(new Class5 { Address = "as", Id = 2, Name = "Kiran-1" });
            class5.list2.Add(new Class5 { Address = "as", Id = 3, Name = "Kiran-2" });


            foreach (var item in class5.list2)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Address);
            }


            Console.ReadKey();

        }
    }
}
