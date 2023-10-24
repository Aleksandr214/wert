//string[,]table=new string[2,5];


//table[1,2]="слово";
//for (int rous = 0; rous < 2; rous++)

//{
// for (int colons = 0; colons < 5; colons++)
// {
//    Console.WriteLine($"{table[rous,colons]}");
// }   
//}

//int [,]matrix=new int[3,4];
int[,] pic=new int[23,25];

void PrintImage(int[,] image)
{
for (int i = 0; i < image.GetLength(0); i++)
  {
    for (int j = 0; j < image.GetLength(1); j++)
    {
         //Console.Write($"{image[i, j]} ");

      if(image[i,j]==0) Console.Write($" ");
      else Console.Write($"+");
     } 
      Console.WriteLine();
  }

}

void FillImage(int row,int col)
{
  if(pic[row,col]==0)
  {
    pic[row,col]=1;
    FillImage(row-1,col);
    FillImage(row,col-1);
    FillImage(row+1,col);
    FillImage(row,col+1);   
  }

}
PrintImage(pic);
FillImage(13,13);
PrintImage(pic);
//{

   // for (int i = 0; i < matr.GetLength(0); i++)
    //{
      //for (int j = 0; j < matr.GetLength(1); j++)
        //{
          // matr[i,j]=new Random().Next(1,10);
        //}
   // }
//}
//PrintArray(matrix);
//FillArray(matrix);
//Console.WriteLine();
//PrintArray(image);
//PrintImage(pic);