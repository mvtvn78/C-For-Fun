using Mvt;
namespace BasicCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOP
            Engine[] engines = new Engine[2];
            engines[0] = new Motobike();
            engines[1] = new Car();
            foreach (Engine engine in engines)
            {
                engine.Move();
            }
        }
    }
}
