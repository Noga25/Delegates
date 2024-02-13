namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A_List A_List = new A_List();

            //The 10 iteams
            A_List.TryAdd("se");
            A_List.TryAdd("1");
            A_List.TryAdd("2");
            A_List.TryAdd("3");
            A_List.TryAdd("4");
            A_List.TryAdd("5");
            A_List.TryAdd("6");
            A_List.TryAdd("fills");
            A_List.TryAdd("se");
            A_List.TryAdd("se");
        }
    }
}