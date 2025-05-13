namespace hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hesaplama uygulamasına hoş geldiniz! \nToplama için 1, çıkarma için 2, çarpma için 3, bölme için 4, çıkmak için 0 a basın");
                int choose;
                Console.Write("Seçiminiz: ");

                if (!int.TryParse(Console.ReadLine(), out choose))
                {
                    Console.WriteLine("Gerçersiz bir işlem yaptınız");
                    continue;
                }

                if (choose == 0)
                {
                    Console.Write("Çıkılıyor.");
                    Thread.Sleep(500);
                    Console.Write("\rÇıkılıyor..");
                    Thread.Sleep(500);
                    Console.Write("\rÇıkılıyor...");
                    Thread.Sleep(500);
                    Console.Write("\rProgramdan çıkıldı...\n");
                    break;
                }
                if (choose < 1 || choose > 4)
                {
                    Console.WriteLine("Geçersiz seçim! 1-4 arasında bir sayı giriniz.");
                    continue; 
                }
                Console.Write("Birinci sayıyı giriniz: ");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("İkinci sayıyı giriniz: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                bool isAcceptable = true;

                switch (choose)
                {
                    case 1:
                        result = Plus(number1, number2);
                        break;
                    case 2:
                        result = Minus(number1, number2);
                        break;
                    case 3:
                        result = Multiply(number1, number2);
                        break;
                    case 4:
                        if (number2 == 0)
                        {
                            Console.WriteLine("0 ile bölme yapılamaz!");
                            isAcceptable = false;
                        }
                        else
                        {
                            result = Divide(number1, number2);
                        }
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim! 1-4 arasında bir sayı giriniz.");
                        isAcceptable = false;
                        break;
                }
                if (isAcceptable == true)
                {
                    Console.WriteLine("İşleminizin sonucu: " + result);
                }
            }
        }   
        static int Plus(int a, int b)
        { return a + b; }
        static int Minus(int a, int b)
        { return a - b; }
        static int Multiply(int a, int b)
        { return a * b; }
        static int Divide(int a, int b)
        { return a / b; }
    }
}
