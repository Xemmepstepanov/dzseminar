Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
int resaul = num1;

if (num1 > 10000 && num1 < 99999)
{
    while (num1 > 0)
    {
        num2 *= 10;
        num2 += num1 % 10;
        num1 /= 10;

    }
    if (resaul == num2)


        Console.Write("является палиндромом " + num2);
    else
    {
        Console.Write("не является палиндромом" + num1);
    }

}
else
{
    System.Console.WriteLine("некорректное число");
}