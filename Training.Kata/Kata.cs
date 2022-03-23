namespace Training.Kata.Main
{
    public class Kata
    {
        public static void Main(string[] args)
        {
            var weights = Weight_for_weight.Kata.orderWeight("11 11 2000 10003 22 123 1234000 44444444 9999");
            Console.WriteLine(weights);
            Console.ReadLine();
        }
    }
}