using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsernameAndPasswordControlPanel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deneme = 3;
            string gelenUserName;
            string gelenPassword;
            string userName = "rezansenturk";
            string password = "1234";
        basaDon: Console.Write("Kullanıcı Adı: ");
            gelenUserName = Console.ReadLine();
            Console.Write("Şifre: ");
            gelenPassword = Console.ReadLine();
            if (userName == gelenUserName && password == gelenPassword)
            {
                Console.ForegroundColor = ConsoleColor.Green; //*ForegroundColor: ekrana yazdırılacak kosulun renkli olmasını sağlar                       
                Console.WriteLine("Giriş Başarılı.");
            }
            else
            {
                deneme--;
                Console.WriteLine("Kullanıcı adı veya şifre hatalı.");
                Console.WriteLine("Kalan deneme sayısı :" + deneme);

                if (deneme == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hesabınız bloke olmuştur.");
                    Thread.Sleep(5000); //console ekranını 5 saniye bekletir
                    Environment.Exit(0); //Console ekranını kapatır.
                }
                goto basaDon;
            }
            Console.ReadKey();
        }
    }
}
