

string testeFile = Path.Combine(@"C:\Users\user\source\", "temp.txt");
string textData = File.ReadAllText(testeFile);

var data = textData.Split(Environment.NewLine);

foreach (var item in data)
{
    string month = string.Empty;
    int largest = 0;
    int number = 0;

    var line = item.Split(',');

    for (int i = 0; i < line.Length; i++)
    {
        if (i == 0)
            month = line[i];

        int.TryParse(line[i], out number);

        if (number > largest)
            largest = number;
    }

    Console.WriteLine("The largest number for the month of {0} was {1}", month, largest);
}

