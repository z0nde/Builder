namespace ExamBuilder
{
    public class Program
    {
        static void Main()
        {
            var LADA = new ProdactCar();
            LADA.MakeLite("2107");
            Console.WriteLine();
            var TOYOTA = new ProdactCar();
            TOYOTA.MakeMedium("MARK II JZX105");
            Console.WriteLine();
            var AUDI = new ProdactCar();
            AUDI.MakeHight("A8");
            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}