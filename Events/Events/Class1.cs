using System.Reflection.Metadata.Ecma335;

namespace Events
{
    public class Class1
    {
        private Program _program = new ();

        public Class1()
        {
            ShowHandler += _program.Show;
        }

        public event Action<bool> ShowHandler;
        public double Multiply(double a, double b) => a * b;

        // temporary
        public void InvokeInvocation()
        {
            Console.WriteLine("I'm invoking invocation!");
            ShowHandler.Invoke(false);
        }
    }
}
