// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);   
        index = index + 1;
        //index++;
    }
}
void printArray(int[] col)
{
        int count = col.Length;
        int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
printArray(array);

//int indexof(int[] collection, int find);
//void FillArray(int[] collection);
//void PrintArray(int[] col)
//{
  //  int index = collection, length;
    //int count = -1;
    //int position = 0;
    //while(index < count)
    //{
        //if(collection[index] == find)
      //  {
          //  position = index;
          //  break;
       // }
       // index++;
    //}
   // return position;
//}
//FillArray(array);
//printArray(array);
//Console.WriteLine();
//int pos = indexof(array, 4);
//printArray(array);
//Console.WriteLine(pos);