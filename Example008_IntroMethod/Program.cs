int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2>result) result=arg2;
  if (arg3>result) result=arg3;
  return result;
}

int a1 = 13;
int b1 = 14;
int c1 = 15;
int a2 = 80;
int b2 = 17;
int c2 = 18;
int a3 = 19;
int b3 = 20;
int c3 = 2991;

int max1 = Max (a1,b1,c1);
int max2 = Max (a2,b2,c2);
int max3 = Max (a3,b3,c3);
int max = Max (max1,max2,max3);

Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);
Console.WriteLine(max);