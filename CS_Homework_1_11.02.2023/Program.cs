Console.WriteLine("Введите первое число:");
string first_number = Console.ReadLine();
int user_first_number = Convert.ToInt32(first_number);
Console.WriteLine("Введите второе число:");
string second_number = Console.ReadLine();
int user_second_number = Convert.ToInt32(second_number);
int max_num = 0;
int min_num = 0;
if (user_first_number > user_second_number)
{
    max_num = user_first_number;
    min_num = user_second_number;
}
if (user_first_number < user_second_number)
{
    max_num = user_second_number;
    min_num = user_first_number;
}
Console.Write("max = ");
Console.WriteLine(max_num);
Console.Write("min = ");
Console.WriteLine(min_num);