using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace Events
{
    public class Class2
    {
        private Class1 _class1 = new ();
        private double _resultOfMultiply;

        // access point
        public Predicate<double> Calculate(Func<double, double, double> handler, double a, double b)
        {
            handler = _class1.Multiply;
            _resultOfMultiply = handler.Invoke(a, b);
            Predicate<double> predicateForResult = Result;
            return predicateForResult;
        }

        public bool Result(double a)
        {
            if (_resultOfMultiply % a == 0)
            {
                return true;
            }

            return false;
        }
    }
}
