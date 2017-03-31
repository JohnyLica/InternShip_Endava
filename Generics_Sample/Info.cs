using System;

namespace Generics_Sample
{
    public class Info<T> where T : IUserInfo, new()
    {
        private readonly T[] UserList;
        private int i;

        private T obj = new T();

        public Info()
        {
            UserList = new T[3];
            i = 0;
        }

        public void Add(T obj)
        {
            if (i == 3) return;
            UserList[i] = obj;
            i++;
        }

        public void ReWrite()
        {
            foreach (var t in UserList)
                Console.WriteLine(t.ToString());
        }
    }
}