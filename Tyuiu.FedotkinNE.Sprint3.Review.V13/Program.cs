using Tyuiu.FedotkinNE.Sprint3.Review.V13.Lib;

namespace Tyuiu.FedotkinNE.Sprint3.Review.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример использования
            DataService ds = new DataService();
            double[] data = { -5.0, -4.0, -3.0, -2.0, -1.0, 0, 1.0, 2.0, 3.0, 4.0, 5.0};

            // Функция для возведения в квадрат
            Func<double, double> myFunction = x => (((3 * x) + 2) - (((2 * x) - 1) / (Math.Cos(x) + 1)));

            // Вызываем функцию Calculate
            ds.Calculate(ds.GenerateData(), myFunction);

        }
    }
}
