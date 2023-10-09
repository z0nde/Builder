using System.Runtime.CompilerServices;

namespace ExamBuilder
{
    public class ProdactCar
    {
        public void MakeLite(string name)
        {
            var carlite = new Cars();
            carlite.Frame();
            carlite.Engine();
            carlite.Make();
            Console.WriteLine($"{name}");
        }

        public void MakeMedium(string name)
        {
            var carlite = new Cars();
            carlite.Frame();
            carlite.Engine();
            carlite.Saloon();
            carlite.ABS();
            carlite.Make();
            Console.WriteLine($"{name}");
        }

        public void MakeHight(string name)
        {
            var carlite = new Cars();
            carlite.Frame();
            carlite.Engine();
            carlite.Saloon();
            carlite.ABS();
            carlite.ESP();
            carlite.Make();
            Console.WriteLine($"{name}");
        }
    }
}
