//task 1

// int n = Convert.ToInt32(Console.ReadLine());
//     int EvenCount(int n)
//     {
//     int  Even=0;
//         for(int i=1; i<=n; i*=10)
//         {
//         int rev=0;
//             rev = n/i%10;
//         if( rev%2==0)
//         {
//               Even++;
//         }
//         }
//         return Even;
//     }
//         int result =EvenCount(n);
//         Console.WriteLine($"Even: {result}");




//     int OddCount(int n)
//     {
//     int  Odd=0;
//         for(int i=1; i<=n; i*=10)
//         {
//         int rev=0;
//             rev = n/i%10;
//         if( rev%2!=0)
//         {
//               Odd++;
//         }
//         }
//         return Odd;
//     }
//         int result2 =OddCount(n);
//          Console.WriteLine($"Odd: {result2}");


//     int DigitCount(int n)
//     {
//      int  Digit=0;

//         for(int i=1; i<=n; i*=10)
//         {
//          Digit++;
//         }
//         return Digit;
//     }
//         int result3 =DigitCount(n);
//          Console.WriteLine($"Digit: {result3}");

//     int SumCount(int n)
//     {
//         int  Sum=0;
//         int rev=0;
//         for(int i=1; i<=n; i*=10)
//         {
//             rev = n/i%10;
//             Sum+=rev;
//         }
//         return Sum;
//     }
//         int result4 =SumCount(n);
//          Console.WriteLine($"Sum: {result4}");


//task 2

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// int Summ (int a, int b)
// {
//     return a+b;
// }
// int result = Summ(a,b);
// Console.WriteLine($"Add: {result}");


// int Subtract (int a, int b)
// {
//     return a-b;
// }
// int result2 = Subtract(a,b);
// Console.WriteLine($"Subtract: {result2}");


// int Multiply  (int a, int b)
// {
//     return a*b;
// }
// int result3 = Multiply (a,b);
// Console.WriteLine($"Multiply: {result3}");


// int Division  (int a, int b)
// {
//     return a/b;
// }
// int result4 = Division  (a,b);
// Console.WriteLine($"Division : {result4}");

//task 3

// int n = Convert.ToInt32(Console.ReadLine());
// int MinDigit(int n)
// {
// int  Min=9999;
//     for(int i=1; i<=n; i*=10)
//     {
//     int rev=0;
//         rev = n/i%10;
//     if( rev<Min)
//     {
//           Min=rev;
//     }
//     }
//     return Min;
// }
//     int result =MinDigit(n);

// int MaxDigit(int n)
// {
// int Max=-9999;
//     for(int i=1; i<=n; i*=10)
//     {
//     int rev=0;
//         rev = n/i%10;
//     if( rev>Max)
//     {
//           Max=rev;
//     }
//     }
//     return Max;
// }
//     int result2 =MaxDigit(n);

//     Console.WriteLine($"{result}+{result2}={result+result2}");

//task 4

// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());

// int Pow(int x,int y)
// {
//     int Output=x;
//     for(int i=1; i<y; i++)
//     {
//         Output*=x;
//     }
//     return Output;
// }
//     int result = Pow(x,y);
//     Console.WriteLine($"{result}");

// task 5
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = Convert.ToInt32(Console.ReadLine());
//     Swap(ref a,ref b);
//  void Swap(ref int a, ref int b)
// {
//     int c;
//     c=a;
//     a=b;
//     b=c;
//     Console.WriteLine($"vareble_1: {a}");
//     Console.WriteLine($"vareble_2: {b}");


// }


//task 7



