int [] array = {2, 5, 4, 91, 21, 4, 65, 58, 99};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }

    index++;
}



