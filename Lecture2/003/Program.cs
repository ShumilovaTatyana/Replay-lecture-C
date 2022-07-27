// Есть массив array из n элементов, требуется найти элемент массива, равный find

int[] array = { 11, 222, 33, 40, 75, 96, 67, 11 };
int n = array.Length;
int find = 11;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
}
