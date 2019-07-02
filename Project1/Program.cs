using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string id, pass,tim="";
            string[] oldpass= new string[100];
            id = "root";
            pass = "toor";
            Send:
            Console.Write("Kullanıcı Adı : ");
            string kullaniciadi = Console.ReadLine();
            Console.Write("Parola : ");
            string parola = Console.ReadLine();
            for (int j = 0; j < 100; j++)
            {
                if (oldpass[j] == pass)
                {
                    Console.WriteLine("Eski Şifrenizi Girdiniz , Şifre Değiştirilme Tarihi : {0}",tim);
                    DateTime time2 = DateTime.Now;
                    Console.WriteLine(time2);
                    goto Send;
                }                
            }
            if (kullaniciadi==id && parola==pass)
            {
                Console.WriteLine("Girişiniz Onaylandı");        
            }            
            else
            {
                Console.WriteLine("Yanlış Kullanıcı Adı veya Parola");
                Console.Write("Şifrenizi Değiştirmek İster misiniz? Y/N : ");
                string ans = Console.ReadLine();
                if (ans == "Y" || ans == "y")
                {
                    Console.Write("Yeni Şifrenizi Giriniz : ");
                    oldpass[i] = pass;
                    pass = Console.ReadLine();                   
                    DateTime time1 = DateTime.Now;
                    tim = time1.ToString();
                    i++;
                    Console.Clear();
                    goto Send;
                }
                else if(ans == "N" || ans =="n")
                {

                }
            }
            Console.ReadKey();           
        }
    }
}
