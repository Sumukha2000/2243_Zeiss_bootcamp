namespace Runtimepolymorphism
{
    class TataCar
    {
        IEngineType _engineType;
        public TataCar(IEngineType engine)
        {
            this.engineType = engine;
        }
       
        public void Ignite()
        {
            _engineType.Start();
        }
        public void Halt()
        {
            _engineType.Stop();
        }
    }

    interface IEngineType
    {
        void Start(); //default methods are public

        void Stop(); //default methods are public
    }
    class RevtronEngine : IEngineType
    {
        public void Start()
        {
            Console.WriteLine("Revtron Ignited");
        }
        public void Stop() { }
    }
    class VericoreEngine
    {
        public void Start()
        {
            Console.WriteLine("Vericore Ignited");
        }
        public void Stop() { }

    }
    class KrytoechEngine
    {
        public void Start()
        {
            Console.WriteLine("Krytoech Ignited");
        }
        public void Stop() { }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            IEngineType _engine=new RevtronEngine();
            TataCar _nexon = new TataCar(_engine);
            _nexon.Ignite();


            _engine = new KrytoechEngine()
             TataCar _harrier = new TataCar(_engine); //Kryotech engine
            _nexon.Ignite();

            



        }
    }
}


