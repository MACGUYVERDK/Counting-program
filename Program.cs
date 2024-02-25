
// Program for counting number of digits in example number



int number = 6529985;
string numberString = number.ToString();
char[] letters = numberString.ToCharArray();
Console.WriteLine("Example number " + number);

List<int> counters = new List<int>(10);


for (int i = 0; i < 10; i++)
{
    counters.Add(0);
}

foreach (char letter in letters)
{
    if(char.IsDigit(letter))
    {
        int digit = letter - '0';
        counters[digit]++;
    }
}

for (int i = 0;i < 10; i++ )
{
    Console.WriteLine(i + " = " + counters[i]);
}