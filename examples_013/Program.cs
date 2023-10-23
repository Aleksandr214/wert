string[,]table=new string[2,5];


//table[1,2]="слово";
//for (int rous = 0; rous < 2; rous++)

//{
// for (int colons = 0; colons < 5; colons++)
// {
//    Console.WriteLine($"{table[rous,colons]}");
// }   
//}

//int [,]matrix=new int[3,4];
int [,] pic=new int[,];

void PrintImage(int[,]image)
{


    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
         //Console.Write($"{image[i, j]} ");

        if(image[i,j]==0)Console.Write($" ");
        else Console.Write($"+");
        } 
        Console.WriteLine();
    }

}
//void FillArray(int[,]matr)
//{

  //  for (int i = 0; i < matr.GetLength(0); i++)
    //{
      //  for (int j = 0; j < matr.GetLength(1); j++)
        //{
          //  matr[i,j]=new Random().Next(1,10);
        //}
    //}
//}
//PrintArray(matrix);
//FillArray(matrix);
//onsole.WriteLine();
//PrintArray(matrix);
PrintImage(pic);