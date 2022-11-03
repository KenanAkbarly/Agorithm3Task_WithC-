//Drop the constants
int[] array = new int[] {1, 2, 3, 4};
int[] newArr = array;
int i;
int j;
Console.WriteLine("Donguden evvel");
for (i = 0; i < newArr.Length; i++)     //O(n)
{
    Console.WriteLine(newArr[i]);       //O(1)
}
Console.WriteLine("Donguden sonra");
for (j = 0; j < newArr.Length; j++)     //O(n)
{
    Console.WriteLine(newArr[j]+1);     //O(1)
}

//This is O(2n), which we just call O(n).