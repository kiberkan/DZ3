Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string len = Convert.ToString(number);
int len1 = len.Length;

if (len1 == 5)
{
    if (len[0] == len[4] && len[1] == len[3])
    {
        Console.WriteLine("Число: "+number+" - алиндром");
    }
    else
    {
        Console.WriteLine("Число: "+number+" - не палиндром");
    }
}
else
{
    Console.WriteLine("ERROR: " +number+ " - не является пятизначным");
}