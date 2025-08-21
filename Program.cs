public class Program
{
    public static double CelsiusToFahrenheit(double C)
    {
        double F = (9.0 / 5) * C + 32;
        return F;
    }
    public static double FahrenheitToCelsius(double F)
    {
        double C = (5.0 / 9) * (F - 32);
        return C;
    }
     public static void Main(String[] args)
 {
     double F;
     double C;
     int choice;

     do
     {
          Console.WriteLine("Menu.");
          Console.WriteLine("1. Đổi độ F sang độ C");
          Console.WriteLine("2. Đổi độ C sang độ F");
          Console.WriteLine("0. Thóat");
          Console.WriteLine("Nhập vào lựa chọn của bạn: ");
          choice = Convert.ToInt32(Console.ReadLine());

          switch (choice)
          {
            case 1: 
            Console.WriteLine("Nhập vào nhiệt độ F: ");
            F = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Đổi độ F sang độ C: " + FahrenheitToCelsius(F));
                    Environment.Exit(0);
            break;
            case 2: 
            Console.WriteLine("Nhập vào nhiệt độ C: ");
            C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Đổi độ C sang độ F: " + CelsiusToFahrenheit(C));
            Environment.Exit(0);
            break;
            case 0:
                Environment.Exit(0);
                break;
          }
     } while (choice != 0);
 }
}