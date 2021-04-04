using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    class Coupons
    {
        public static void ReadNumOfCoupons()
        {
            Console.WriteLine("Enter the num for distinct coupons");
            int couponNo = Convert.ToInt32(Console.ReadLine());
            FindOutRandomCount(couponNo); //calling Findoutrandom() method
        }
        private static void FindOutRandomCount(int CouponNo)
        {
            int distinct = 0, count = 0;
            bool[] iscollected = new bool[CouponNo];
            while (distinct < CouponNo)
            {
                Random random = new Random();
                int newRandom = Convert.ToInt32(random.Next(0, CouponNo));
                count++;
                if (!iscollected[newRandom])
                {
                    distinct++;
                    iscollected[newRandom] = true;
                }
            }
            Console.WriteLine("total random number needed to have all distict coupons:" + count);
        }
    }
}




