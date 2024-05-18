namespace asal_sayı_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen alt sınır asal sayıyı giriniz");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if(input1<=1)
            {
                input1=2;
            }
            try
            {
                Console.WriteLine("Lütfen üst sınır asal sayıyı giriniz");
                int input2 = Convert.ToInt32(Console.ReadLine());
                if(input2<=input1)
                {
                    Console.WriteLine("Düzgün Değerler Gir");
                }

                for (int i = input1; i <= input2; i++)
                {
                    int sayac = 0;
                    for (int j = 2; j <= i - 1; j++)
                    {
                        if (i % j == 0)
                        {
                            sayac = 1;
                        }
                    }
                    if (sayac != 1)
                    {
                        Console.WriteLine(i + "--> asaldır.");
                    }
                }
            }
            catch(OverflowException)
            {
                Console.WriteLine("Üst Sınırı Çok Büyük Bir Sayı Girdiniz.");
            }

            
            

        }
    }
}
