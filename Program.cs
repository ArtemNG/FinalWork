//string[] array = {"lol","kek","cheburek",":)","123"};

System.Console.WriteLine("Введите слова через пробел: ");
string[] array =  Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
int count = 0;
string[] outArr = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        outArr[count] = array[i];
        count++;
    }

}
Array.Resize(ref outArr,count);
System.Console.WriteLine("[{0}]", String.Join(",", outArr));