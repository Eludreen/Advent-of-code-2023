using System.Globalization;
using System.IO;
 
static int lineCheck(string path)
{
    int lineCount = 0;
    //detects the number of lines
    using (StreamReader r = new StreamReader(path))
    {
        lineCount = 0;
        while (r.ReadLine() != null)
        {
            lineCount++;
        }
    }
    return lineCount;
}
static bool intCheck(string testing)
{
    int binner = 0;
    bool isInt = false;
    isInt = int.TryParse(testing, out binner);
    return isInt;
}
 
 
static int readTotal()
{
 
    int total = 0;
    string row_count = " ";
    int num_found = 0;
    string path = "Q1_input.txt";
    int lineCount = lineCheck(path);
    string transferer = " ";
    using (StreamReader r = new StreamReader(path))
    {
        for (int i = 0; i < lineCount; i++)
        {
            row_count = null;
            num_found = 0;
            transferer = null;
            string line = r.ReadLine();
            for (int x = 0; x < line.Length; x++)
            {
                string int_check = (line[x]).ToString();
                if (intCheck(int_check))
                {
                    num_found++;
                    if (num_found == 1)
                    {
                        row_count += int_check;
                    }
                    else
                    {
                        transferer = int_check;
                    }
                }
            }
            if (num_found > 1)
            {
                row_count += transferer;
            }
            else
            {
                row_count += row_count;
            }
            Console.WriteLine(row_count);
            total += (int.Parse(row_count));
 
        }
    }
    Console.WriteLine(total);
    return total;
}
 
static int ReadTotal2()
{
 
    int total = 0;
    string row_count = " ";
    string path = "Q1_input.txt";
    int lineCount = lineCheck(path);
    string transferer = " ";
    string Digit5 = "";
    string Digit4 = "";
    string Digit3 = "";
 
    using (StreamReader r = new StreamReader(path))
    {
        for (int i = 0; i < lineCount; i++)
        {
            row_count = "";
            transferer = "";
            string line = r.ReadLine();
            int num_found = 0;
            int leng = line.Length;
            for (int x = 0; x < leng; x++)
            {
                string int_check = (line[x]).ToString();
                bool isInt = intCheck(int_check);
                if (isInt)
                {
                    num_found += 1;
                    if (num_found == 1)
                    {
                        Console.WriteLine(num_found);
                        row_count += int_check;
                    }
                    else
                    {
                        transferer = int_check;
                    }
                }
                else
                {
                    if ((x + 4) < leng)
                    {
                        Digit5 = line.Substring(x, 5);
                        Digit4 = line.Substring(x, 4);
                        Digit3 = line.Substring(x, 3);
                    }
                    else if ((x + 3) < leng)
                    {
                        Digit4 = line.Substring(x, 4);
                        Digit3 = line.Substring(x, 3);
                        Digit5 = "";
                    }
                    else if ((x + 2) < leng)
                    {
                        Digit3 = line.Substring(x, 3);
                        Digit5 = "";
                        Digit4 = "";
                    }
 
                    switch (Digit5)
                    {
                        case ("three"):
                            num_found += 1;
                            if (num_found == 1)
                            {
                                row_count += "3";
                            }
                            else
                            {
                                transferer = "3";
                            }
                            break;
                        case ("seven"):
                            num_found += 1;
                            if (num_found == 1)
                            {
                                row_count += "7";
                            }
                            else
                            {
                                transferer = "7";
                            }
                            break;
                        case ("eight"):
                            num_found += 1;
                            if (num_found == 1)
                            {
                                row_count += "8";
                            }
                            else
                            {
                                transferer = "8";
                            }
                            break;
                    }
                    switch (Digit4)
                    {
                        case ("four"):
                            num_found += 1;
                            if (num_found == 1)
                            {
                                row_count += "4";
                            }
                            else
                            {
                                transferer = "4";
                            }
                            break;
                        case ("five"):
                            num_found += 1;
                            if (num_found == 1)
                            {
                                row_count += "5";
                            }
                            else
                            {
                                transferer = "5";
                            }
                            break;
                        case ("nine"):
                            num_found += 1;
                            if (num_found == 1)
                            {
                                row_count += "9";
                            }
                            else
                            {
                                transferer = "9";
                            }
                            break;
 
                    }
                    switch (Digit3)
                    {
                        case ("one"):
                            num_found += 1;
                            if (num_found == 1)
                            {
                                row_count += "1";
                            }
                            else
                            {
                                transferer = "1";
                            }
                            break;
                        case ("two"):
                            num_found += 1;
                            if (num_found == 1)
                            {
                                row_count += "2";
                            }
                            else
                            {
                                transferer = "2";
                            }
                            break;
                        case ("six"):
                            num_found += 1;
                            if (num_found == 1)
                            {
                                row_count += "6";
                            }
                            else
                            {
                                transferer = "6";
                            }
                            break;
 
                    }
                }
 
            }
            if (num_found > 1)
            {
                row_count += transferer;
            }
            else
            {
                row_count += row_count;
            }
            Console.WriteLine(row_count);
            total += (int.Parse(row_count));
            num_found = 0;
        }
    }
    return total;
}
Console.WriteLine("D1: Q1 or 2?");
string num = Console.ReadLine();
int total = 0;
if (num == "1")
{
     total = readTotal();
}
else if (num == "2")
{
     total = ReadTotal2();
}
 
Console.WriteLine(total);