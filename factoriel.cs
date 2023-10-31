using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class Program
{
	public static void Main()
	{
		//علی پیر محمد جماعت و حمیدرضا واحدی و مهدی نوروزی   پیشرفته 1    شمسی پور
              Console.WriteLine("سلام وقت بخیر بریم که فاکتوریل اعداد رو برات حساب کنم");
              Console.WriteLine("یک عدد بنویس تا برات فاکتوریلش رو حساب کنم");
              int num = Convert.ToInt32(Console.ReadLine());
              int x = 1;
              for(int i=1; i <= num; i++)  {x *= i;}
              Console.WriteLine(x);
              Console.WriteLine("تقدیم شما موفق باشی"); 
	}
}