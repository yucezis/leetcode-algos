using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sıcaklık Dönüştürücüye Hoş Geldiniz ===");
            Console.Write("Lütfen Celsius değerini giriniz: ");

            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double[] results = ConvertTemperature(celsius);

                Console.WriteLine("\r\n--- Sonuçlar ---");
                Console.WriteLine($"Celsius: {celsius}°C");
                Console.WriteLine($"Kelvin:  {results[0]} K");
                Console.WriteLine($"Fahrenheit: {results[1]} °F");
            }
            else
            {
                Console.WriteLine("Hata: Lütfen geçerli bir sayısal değer giriniz.");
            }

            Console.WriteLine("\r\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }

        public static double[] ConvertTemperature(double celsius)
        {
            double kelvin = celsius + 273.15;
            double fah = celsius * 1.8 + 32.0;

            return new double[] { kelvin, fah };
        }
    }
}