using Algorithms.Methods;


namespace Algorithms
{
    internal class Program
    {
        //TODO: - Implement all algorithms here
        static void Main(string[] args)
        {
            int answer = BinarySearch.Search(new int[] { 1, 2, 3, 4, 5 }, 3);
            Console.WriteLine("Your answer is: " + answer);
        }
    }
}
