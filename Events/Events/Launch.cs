using Events;

public class Launch
{
    public event Func<double, double, double> MultiplyHandler;
    public static void Main(string[] args)
    {
        Launch launch = new Launch();
        Class1 sample1 = new ();
        Class2 sample2 = new ();
        Program program = new Program();
        var result = sample2.Calculate(launch.MultiplyHandler, 2, 3);
        program.Show(result(2)); // true
        program.Show(result(7)); // false
        program.Show(result(3)); // true
        program.Show(result(4)); // false
    }
}