using System;

namespace Generics_Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var database1 = new Info<AllInfoUser>();
            database1.Add(new AllInfoUser(uName: "Johny", Family: "Lica", uAge: 26));
            database1.Add(new AllInfoUser(uName: "VAsile", Family: "Cudalb", uAge: 28));
            database1.Add(new AllInfoUser(uName: "Carl", Family: "Zeins", uAge: 50));

            database1.ReWrite();

            var user1 = new AllInfoUser(uName: "Alex", Family: "Sponcea", uAge: 123);
            var s = InfoObject.Info(user1);
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}