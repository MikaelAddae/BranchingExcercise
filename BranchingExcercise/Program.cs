namespace BranchingExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("New Branch");
            git remote add origin https://github.com/MikaelAddae/BranchingExcercise.git
            git branch -M main
            git push - u origin main
        }
    }
}