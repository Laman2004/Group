using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qrup nomresini daxil edin:");
            string nomre = Console.ReadLine();
            Console.WriteLine(GroupNo(nomre));
            Console.WriteLine("Telebelerin max sayini daxil edin:");
            int num;
            string str=Console.ReadLine();
            while(!int.TryParse(str, out num))
            {
                Console.WriteLine("Daxil etdiyiniz deyer duzgun deyil");
                str= Console.ReadLine();    
            }
            string[] telebe_ad = new string[num];
            string[] telebe_soyad = new string[num];
            for (int i = 0; i < telebe_ad.Length; i++)
            {
                Console.WriteLine("Telebenin adini daxil edin");
                telebe_ad[i] = Console.ReadLine();
                Console.WriteLine("Telebenin soyadini daxil edin");
                telebe_soyad[i] = Console.ReadLine();
            }
            Group group = new Group(num)
            {
                Name = telebe_ad,
                Surname = telebe_soyad,
                GroupNo = nomre
            };

            group.GetInfo();
        }
        static bool GroupNo(string no)
        {
            int say1=0;
            int say2=0;
            for (int i = 0; i < no.Length; i++)
            {
                    if (char.IsUpper(no[i]))
                    {
                    say1++;
                    }
                else if (char.IsDigit(no[i]))
                {
                    say2++;
                }
                if(no.Length==5 && say1==2 && say2==3)
                {
                    return true;
                }
            }return false;
        }
    }
}
 