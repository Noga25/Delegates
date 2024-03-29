﻿namespace Delegates
{
    internal class A_List
    {
        List<string> list = new List<string>() { };
        public event Action<string> ListChanged;
        private Predicate<string> _Predicate;

        public void Observable_Limited_List(Predicate<string> predicate)
        {
            _Predicate = predicate;
        }

        public bool TryAdd(string userName)
        {
            //_predicate.invoke("S")

            if (userName.StartsWith("S"))
            {
                list.Add(userName);
                ListChanged?.Invoke(userName);
                Add(userName);
                return true;
            }

            else 
            {
                Console.WriteLine("The word does not meet the requirements");

                return false;
            }
        }

        public void Add(string userName)
        {
            Console.WriteLine(userName);
        }

        private void OnListChanged(string message)
        {
            ListChanged?.Invoke(message);
        }

        public void PrintAllIteams()
        {
            foreach (var iteams in list)
            {
                Console.WriteLine(iteams);
            }
        }
    }
}
