// See https://aka.ms/new-console-template for more information

int[] array = { 1, 12, 13, 4, 81, 51, 61, 17, 81 };
int n = array.Length;
int find = 81;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}