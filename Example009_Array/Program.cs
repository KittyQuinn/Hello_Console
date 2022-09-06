int[] array = {60,20,9,14,73,20,77};
int n = array.Length;
int find = 20;
int index = 0;

while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}