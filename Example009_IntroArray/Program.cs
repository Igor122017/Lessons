// See https://aka.ms/new-console-template for more information
// Lektion from 10.07.2022
int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if(arg2>result) result = arg2;
   if(arg3>result) result = arg3; 
   return result;
}
int[] array = { 11, 2, 31, 24, 51, 16, 71, 18, 9 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);

