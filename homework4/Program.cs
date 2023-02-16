Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int evenNum = 2;

if(num > 1)
{
    while(evenNum <= num)
    {
        Console.Write(evenNum + " ");
        evenNum = evenNum + 2;
    }
}
