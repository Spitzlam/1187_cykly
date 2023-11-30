/*
int userinput1 = 17;
for (int i = userinput1;i <= 20; i++ )
{
    Console.WriteLine(i);
}
//
//
bool proceed = true;
while (proceed)
{
    string userinput2 = Console.ReadLine();
    if (userinput2 == "pls help")
    {
        proceed = false;
    }
    else
    {
        for (int i = 1;  i <= 3; i++ )
        {
            Console.WriteLine(userinput2);
        }
    }
}
*/
//
Random generator = new Random();
bool alpha = true;
while (alpha)
{
    string input = Console.ReadLine();
    if (input != "ne")
    {
        Console.WriteLine(generator.Next(1, 10));
    }
    else
    {
        alpha = false;
    }
}
//
//
for (char i = 'R'; i <= 'Z'; i++)
{
    Console.WriteLine(i);
}

