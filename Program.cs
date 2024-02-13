namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A_List A_List = new A_List();

            A_List.TryAdd("Server");
            A_List.TryAdd("1");
        }
    }
}