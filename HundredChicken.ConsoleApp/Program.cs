using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredChicken.ConsoleApp
{
    internal class Program
    {
		//百元買百隻
		//公雞五元一隻 CockPrice = 5
		//母雞三元一隻 HenPrice = 3
		//小雞一元三隻 ChickPrice = 1/3
		//CockAmount + HenAmount + ChickAmount = 100
		//CockAmount*CockPrice + HenAmount*HenPrice + ChickAmount*ChickPrice = 100
		//i.e. CockAmount*5 + HenAmount*3 + ChickAmount*(1/3) = 100
		//i.e. CockAmount*15 + HenAmount*9 + ChickAmount = 300
		//Thus, CockAmount*14 + HenAmount*8 = 200
		static void Main(string[] args)
        {
            for (int CockAmount = 0; CockAmount < 14; CockAmount++)//15*14 = 210 > 200
            {
                for (int HenAmount = 0; HenAmount <= 25; HenAmount++)//25*8 = 200
                {
                    if (CockAmount * 14 + HenAmount * 8 == 200)
                    {
                        int ChickAmount = 100 - CockAmount - HenAmount;//小雞數量=小雞花費*3
                        Console.WriteLine($"公雞{CockAmount}隻," +
                                          $"母雞{HenAmount}隻," +
                                          $"小雞{ChickAmount}隻");
                    }
                }
            }
        }
	}
}
