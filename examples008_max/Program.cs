﻿//нахождение максимума из 9 чисел

Console.WriteLine("нахождение максимум из 9 чисел: ");

int Max(int)

int Max(int ard1, int ard2, int ard3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 10;
int b1 = 12;
int c1 = 14;
int a2 = 16;
int b2 = 17;
int c2 = 19;
int a3 = 21;
int b3 = 24;
int c3 = 25;

//int max = a1;
//if(b1 > max) max = b1;
//if(c1 > max) max = c1; 

//if(a2 > max) max = a2;
//if(b2 > max) max = b2;   
//if(c2 > max) max = c2;

//if(a3 > max) max = a3;
//if(b3 > max) max = b3;
//if(c3 > max) max = c3;

int max1 = Max(a1, b1, c1);
int max1 = Max(a2, b2, c2);
int max1 = Max(a3, b3, c3);
int max1 = Max(max1, max2, max3);

Console.WriteLine(max1);