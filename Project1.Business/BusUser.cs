using Project1.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project1.Business
{
    public class BusUser :User
    {
        public void Login()
        {
            /*
            Console.Write("Kullanıcı İsmini Giriniz : ");
            İD = Convert.ToString(Console.ReadLine());
            if (İD != "")
            {
                Console.Write("Şifrenizi Giriniz : ");
                PASSWORD = Convert.ToString(Console.ReadLine());
            }*/
            string[] hücreler = System.IO.File.ReadAllLines(@"C:\Users\Emin Özbek\Desktop\Kayıt.csv");
            var query = from line in hücreler
                        let data = line.Split(',')                      
                        select new
                        {                            
                            İD1 = data[0],
                            PASSWORD1 = data[1],
                            DATETİM1 = data[2],
                        };
                        
            foreach (var item in query) {
            
                Console.WriteLine("{0}",item.İD1);
                /*if (İD == item.İD1 && PASSWORD == item.PASSWORD1)
                {

                }*/
            }
            Console.ReadKey();
            
        }
    }
}
