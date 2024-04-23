
namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.SetOut(new Scaling(Console.Out));//skaalaus

            UI.GameLoop();//peli
        }
    }
}