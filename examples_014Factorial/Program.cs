
double Factorial(int n) //int поменять на double
{
    if(n==0)return 1;
    else return n*Factorial(n-1);

}
for (int i = 1; i < 40; i++)
{
   Console.WriteLine($"{i}! = {Factorial(i)}"); 
}