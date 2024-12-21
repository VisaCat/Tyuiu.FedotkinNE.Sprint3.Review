namespace Tyuiu.FedotkinNE.Sprint3.Review.V13.Lib
{
    public class DataService
    {
        public void Calculate(double[] data, Func<double, double> function)
        {
            // Проверяем, не пустой ли массив
            if (data.Length == 0)
            {
                Console.WriteLine("Массив пуст.");
                return;
            }

            // Выводим заголовок таблицы
            Console.WriteLine("Исходные значения | Обработанные значения");
            Console.WriteLine("-----------------|----------------------");

            // Проходим по каждому элементу массива
            for (int i = 0; i < data.Length; i++)
            {
                // Вычисляем обработанное значение с проверкой на деление на ноль
                double processedValue = 0;
                try
                {
                    processedValue = function(data[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Ошибка: Деление на ноль для значения {data[i]}");
                }

                // Выводим строку таблицы
                Console.WriteLine($"{data[i]} | {processedValue}");
            }
        }

        // Метод для генерации массива данных
        public double[] GenerateData()
        {
            // Создаем массив с шагом 0.5
            double[] data = new double[21];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = -5 + i * 0.5;
            }
            return data;
        }
    }
}

