using DesignPatternsFinal.Views;
using Figgle.Fonts;

namespace DesignPatternsFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(FiggleFonts.Standard.Render("ALARM: Cheese Pizza"));
            AlarmTests tester = new AlarmTests();
            tester.runTests();
        }
    }
}
