namespace ExamBuilder
{
    public class Cars : ICar
    {
        private bool make { get; set; } = false;
        private bool frame { get; set; } = false;
        private bool engine { get; set; } = false;
        private bool saloon { get; set; } = false;
        private bool abs { get; set; } = false;
        private bool esp { get; set; } = false;

        public void Make()
        {
            make = true;
            if (make)
                Console.Write("Car make ");
        }
        
        public void Frame()
        {
            frame = true;
            if (frame)
                Console.WriteLine("Frame make");
        }

        public void Engine()
        {
            engine = true;
            if (engine)
                Console.WriteLine("Engane swep");
        }

        public void Saloon()
        {
            saloon = true;
            if (saloon)
                Console.WriteLine("Saloon make and swap");
        }

        public void ABS()
        {
            abs = true;
            if (abs)
                Console.WriteLine("ABS download");
        }

        public void ESP()
        {
            esp = true;
            if (esp)
                Console.WriteLine("ESP download");
        }
    }
}
