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
                        result = Toplama(number1, number2);
                        break;
                    case 2:
                        result = Cikarma(number1, number2);
                        break;
                    case 3:
                        result = Carpma(number1, number2);
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
                if (isAcceptable)
                    Console.WriteLine("İşleminizin sonucu: " + result);
            }
        }   
        static int Toplama(int a, int b)
        { return a + b; }
        static int Cikarma(int a, int b)
        { return a - b; }
        static int Carpma(int a, int b)
        { return a * b; }
        static int Divide(int a, int b)
        { return a / b; }
    }
}
