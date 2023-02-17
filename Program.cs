//string[] array = {"lol","kek","cheburek",":)","123"};

System.Console.WriteLine("Введите слова через пробел: ");
string[] array =  Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
int count = 0;
string[] outArr = new string[array.Length];
