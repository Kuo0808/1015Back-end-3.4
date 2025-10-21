using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////習題3-1 寫一個程式、輸入10個整數求其最小值
            //Console.WriteLine("請輸入10個整數");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int min = n;
            //for (int i = 1; i < 10; i++)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    if (n < min)
            //    {
            //        min = n;
            //    }
            //}
            //Console.WriteLine($"最小值為{min}" );

            ////習題3-2 寫一程式、輸入n個整數求其最小值
            //Console.WriteLine("請輸入N個整數");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int min2 = int.MaxValue;
            //for (int i = 0; i<N; i++)
            //    {
            //    int n2 = Convert.ToInt32(Console.ReadLine());
            //    if (n2 < min2)
            //    {
            //        min2 = n2;
            //    }
            //}
            //Console.WriteLine($"最小值為{min2}");

            ////習題3-3 寫一程式、輸入10個整數、列出其中所有大於12的數字
            //Console.WriteLine("請輸入10個整數：");

            //for (int i = 0; i < 10; i++)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num > 12)
            //        Console.WriteLine(num);
            //}

            ////習題3-4 寫一程式、輸入10個整數、列出其中所有大於12的數字的總和
            //Console.WriteLine("請輸入10個整數");
            //int sum = 0;
            //for(int i=0;i<10; i++)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num > 12)
            //    {
            //        sum += num;
            //    }
            //}
            //Console.WriteLine($"大於12的數字總和為{sum}");

            ////習題3-5 寫一程式、輸入n個數字，求其所有奇數中最大的值。例如輸入11,12,13,14,15、則輸出15
            //Console.WriteLine("請輸入整數（輸入 0 結束）：");
            //int maxOdd = int.MinValue;

            //while (true)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num == 0) break; // 0 結束輸入

            //    if (num % 2 == 1 && num > maxOdd)
            //        maxOdd = num;
            //}

            //if (maxOdd == int.MinValue)
            //    Console.WriteLine("沒有輸入任何奇數！");
            //else
            //    Console.WriteLine($"所有奇數中最大的值為 {maxOdd}");

            /////習題3-6寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字，得到12 + (-2)2 + 32 + (-4)2 + 52 = 1 + 9 + 25 = 35
            //Console.WriteLine("請輸入N個數字(輸入0結束)");
            //int sum = 0;
            //while(true)
            // {
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num == 0) break; // 0 結束輸入
            //    if(num>0)
            //    sum += num * num;
            //}
            //Console.WriteLine($"數字平方的總合為{sum}");

            //習題3-7輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如-7會被轉換成7
            //Console.WriteLine("請輸入N個數字，當中負數將被轉變為正數,輸入0則結束");

            //while(true)
            //{
            //    int N = Convert.ToInt32(Console.ReadLine());
            //    if (N == 0)break;
            //    Console.WriteLine(Math.Abs(N)); 
            //}

            //補充習題
            //1.判斷101~200之間有多少的質數，並輸出所有質數。
            //for(int n = 101; n<=200; n++)
            //{
            //    bool isprime = true;
            //    for(int i = 2;i<=Math.Sqrt(n);i++)
            //    {
            //        if(n%i==0)
            //        {
            //            isprime = false;
            //                break;
            //        }
            //    }
            //    if(isprime)
            //        Console.WriteLine($"{n}");
            //}


            ////2.輸入一個數，輸出其質因數
            //Console.WriteLine("請輸入一個數");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"其質因數為:");
            //for(int i = 2; i<=n;i++)
            //{
            //    while (n % i == 0)
            //    {
            //        Console.WriteLine($"{i}");
            //        n /= i;
            //    }
            //}


            //3.求100~到300中可以被3與7整除的整數個數
            //int count = 0; // 用來計算符合條件的數量

            //for (int i = 100; i <= 300; i++)
            //{
            //    if (i % 3 == 0 && i % 7 == 0)
            //    {
            //        count++;
            //        Console.WriteLine(i); // 若想列出符合的數字，可以保留這行
            //    }
            //}
            //Console.WriteLine($"100~300 之間可以被 3 和 7 整除的共有 {count} 個數字。");


            ////習題4-1利用while寫一程式求N個數字的最大值
            //Console.WriteLine("請輸入要輸入幾個數N");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //int max = int.MinValue;   //初始化最大值
            //while (count < N)
            //{ 
            //    Console.WriteLine("請輸入一個整數");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num > max)
            //        max = num;
            //        count++;
            //}
            //Console.WriteLine($"這{N}個數值中最大值是:{max}");


            ////習題4-2利用while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。(即從起始值開始，間格差，共N個的總和)
            //Console.Write("請輸入起始值：");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入公差（每次增加的差值）：");
            //int diff = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入項數 N：");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int count = 0;  // 已加幾項
            //int sum = 0;    // 總和
            //int term = start;  // 目前的項目值
            //while (count < N)
            //{
            //    sum += term;      // 把這一項加進總和
            //    term += diff;     // 下一項加上公差
            //    count++;          // 已計算的項目數 +1
            //}
            //Console.WriteLine($"這個等差級數的總和為：{sum}");


            ////習題4-3利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和。
            //Console.WriteLine("要輸入幾個數N");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //int sum = 0;
            //while(count<N)
            //{
            //    Console.WriteLine("請輸入一個整數");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num < 13)
            //        sum += num;
            //    count++;
            //}
            //Console.WriteLine($"所有小於13的數字總合為:{sum}");


            //習題4- 4利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字
            //Console.WriteLine("請輸入要輸入幾個數");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //bool found = false;
            //while(count<N)
            //{
            //    Console.WriteLine("請輸入一個整數");
            //    int num=Convert.ToInt32(Console.ReadLine());

            //    if(num>7&&num<10)
            //    {
            //        Console.WriteLine($"找到第一個大於7且小於10的數字{num}");
            //        found = true;
            //        break;
            //    }
            //    count++;
            //}
            //if(!found)
            //    Console.WriteLine("沒有任何數字在7和10之間");


            //// 習題4-5利用 while 讀入 a1~a5 和 b1~b5找到第一個 ai > bi 即停止，並列印出 ai 及 bi
            //int i = 1; // 計數器，從第1組開始
            //while (i <= 5)
            //{
            //    Console.Write($"請輸入第 {i} 組的 a{i}：");
            //    int a = Convert.ToInt32(Console.ReadLine());

            //    Console.Write($"請輸入第 {i} 組的 b{i}：");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    if (a > b)
            //    {
            //        Console.WriteLine($"找到第一個 a{i} > b{i}");
            //        Console.WriteLine($"a{i} = {a}, b{i} = {b}");
            //        break;  // 立即停止整個迴圈
            //    }
            //    i++; // 繼續下一組
            //}
            //if (i > 5)
            //{
            //    Console.WriteLine("沒有任何一組符合 a > b 的條件。");
            //}


            //補充習題4-1  漢堡~
            // Eric 吃漢堡紀錄程式
            //Console.Write("請輸入吃漢堡的總時間（分鐘）：");
            //int totalTime = Convert.ToInt32(Console.ReadLine());

            //int time = 0;     // 已經過了幾分鐘
            //int count = 0;    // 吃了幾個漢堡
            //while (time < totalTime)
            //{
            //    time += 5;     // 每 5 分鐘吃一個漢堡
            //    count++;       // 吃的數量 +1
            //    Console.WriteLine($"第 {count} 個漢堡在第 {time} 分鐘吃完");
            //}
            //int totalMoney = count * 39;
            //Console.WriteLine($"總共吃了 {count} 個漢堡，花了 {totalMoney} 元！");



            ////補充習題4-2 貸款~~// 小明貸款還款程式
            //double total = 560;   // 總貸款（單位：萬）
            //double paid = 0;      // 已還金額（單位：萬）
            //int month = 0;        // 紀錄總月數
            //while (paid < total)
            //{
            //    month++; // 每月遞增一次
            //    if (month % 12 == 0) // 每滿12個月（年終）多還1萬
            //    {
            //        paid += 5;  // 還5萬
            //    }
            //    else
            //    {
            //        paid += 4;  // 平常每月還4萬
            //    }
            //}
            //Console.WriteLine($"小明需要 {month} 個月才能還清貸款。");


            ////補充習題4-3猜數字遊戲
            //Random random = new Random();   // 建立隨機物件
            //int answer = random.Next(1, 101); // 產生 1~100 的隨機整數
            //int guess;                       // 使用者輸入的數字

            //Console.WriteLine("系統已產生 1~100 的隨機數字，請開始猜！");

            //while (true)
            //{
            //    Console.Write("請輸入你的猜測：");
            //    guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess > answer)
            //    {
            //        Console.WriteLine("太大了，請再試一次！");
            //    }
            //    else if (guess < answer)
            //    {
            //        Console.WriteLine("太小了，請再試一次！");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"恭喜你猜中！答案是 {answer}");
            //        break; // 猜中就結束迴圈
        }
    }








}











    }
}
