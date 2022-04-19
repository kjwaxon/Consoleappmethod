using System;

namespace ConsoleAppExample
{

    class bilgisayar
    {
        public string ekrankartı;
        public string işlemci;
        public int ram;

        public void yazdır()
        {
            Console.WriteLine("Bilgisayarınızın ekran kartı : " + ekrankartı);
            Console.WriteLine("Bilgisayarınızın işlemcisi : " + işlemci);
            Console.WriteLine("Bilgisayarınızın ram sayısı :{0}gb " , ram );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bilgisayar pc = new bilgisayar();
            pc.ekrankartı = "Rtx 3090";
            pc.işlemci = "i7 9900k";
            pc.ram = 32;

            pc.yazdır();

        }
    }
}
