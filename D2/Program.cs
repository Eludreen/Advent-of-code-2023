using System.Diagnostics;

string path = "D2_input.txt";
static bool intCheck(string toCheck)
{
    int binner = 0;
    bool IsInt = false;
    IsInt = int.TryParse(toCheck, out binner);
    return IsInt;
}
static int LineCount(string path)
{
    int lineCount = 0;
    using (StreamReader r = new StreamReader(path))
    {
        while (r.ReadLine() != null)
        {
            lineCount++;
        }
    }
    return(lineCount);  
}
static bool Allow(string colour, int count)
{
    if (colour == "g")
    {
        if (count <= 13)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    if (colour == "r")
    {
        if (count <= 12)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    if (colour == "b")
    {
        if (count <= 14)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    return false;
}
int total_power = 0;
int greenCount = 0;
int redCount = 0;
int blueCount = 0;
int gameNum = 0;

string digit5 = "";
string digit4 = "";
string digit3 = "";
int lineCount = LineCount(path);
using (var sr = new StreamReader(path))
{
    for (int i = 0; i < lineCount; i++)
    {
        int bigGreen = 0, bigBlue = 0, bigRed = 0;
        Console.WriteLine();
        bool greenAllow = true;
        bool blueAllow = true;
        bool redAllow = true;
        greenCount = 0;
        redCount = 0;
        blueCount = 0;
        string line = sr.ReadLine();
        line = line.Remove(0, 5);
        for (int x = 0; x < line.Length; x++)
        {
            bool isLetter = char.IsLetter(line[x]);
            if (isLetter)
            {
                if (x + 4 < line.Length)
                {
                     digit5 = line.Substring(x, 5);
                     digit4 = line.Substring(x, 4);
                     digit3 = line.Substring(x, 3);
                }
                else if (x + 3 < line.Length)
                {
                    digit5 = "";
                    digit4 = line.Substring(x, 4);
                    digit3 = line.Substring(x, 3);
                }
                else if (x + 2 < line.Length)
                {
                    digit5 = "";
                    digit4 = "";
                    digit3 = line.Substring(x, 3);
                }
                else
                {
                    digit5 = "";
                    digit4 = "";
                    digit3 = "";
                }


                if (digit5 == "green")
                {
                    bool ints2 = intCheck(line[x - 3].ToString());
                    if (ints2)
                    {
                        string transfer = ((line[x - 3].ToString()) + (line[x - 2].ToString()));
                        greenCount = int.Parse(transfer);
                    }
                    else
                    {
                        greenCount = int.Parse(line[x - 2].ToString());
                    }
                    if (bigGreen < greenCount)
                    {
                        bigGreen = greenCount;
                    }
                    if (greenAllow)
                    {
                        greenAllow = Allow("g", greenCount);
                    }
                }
                if (digit4 == "blue")
                {
                    bool ints2 =  intCheck(line[x - 3].ToString());
                    if (ints2)
                    {
                        string transfer = ((line[x - 3].ToString()) + (line[x - 2].ToString()));
                        blueCount = int.Parse(transfer);
                    }
                    else
                    {
                        blueCount = int.Parse(line[x - 2].ToString());
                    }
                    if (bigBlue < blueCount)
                    {
                        bigBlue = blueCount;
                    }
                    if (blueAllow)
                    {
                        blueAllow = Allow("b", blueCount);
                    }

                }
                if (digit3 == "red")
                {
                    bool ints2 =  intCheck(line[x - 3].ToString());
                    if (ints2)
                    {
                        string transfer = ((line[x - 3].ToString())+(line[x - 2].ToString()));
                        redCount = int.Parse(transfer);
                    } 
                    else
                    {
                        redCount = int.Parse(line[x - 2].ToString());
                    }
                    if (bigRed < redCount)
                    {
                        bigRed = redCount;
                    }
                    if (redAllow)
                    {
                        redAllow = Allow("r", redCount);
                    }

                }


            }

        }
        int powerTrans = (bigBlue * bigRed * bigGreen);
        Console.WriteLine(powerTrans);
        total_power += powerTrans;
        if ((redAllow) && (blueAllow) && (greenAllow))
        {

            string transfer = "";
            int first = 0;
            bool intsis = intCheck(line[0].ToString());
            if (intsis)
            {
                bool intsis2 = intCheck(line[1].ToString());
                if (intsis2)
                {
                    bool intsis3 = intCheck(line[2].ToString());
                    if (intsis3)
                    {
                         transfer = ((line[0].ToString()) + (line[1].ToString()) + (line[2].ToString()));
                    }
                    else
                    {
                        transfer = ((line[0].ToString()) + (line[1].ToString()));
                    }
                }
                else
                {
                    transfer = (line[0].ToString());
                }

            }
            first = int.Parse(transfer);
            gameNum += first;
        }
    }
}
Console.WriteLine("Q1 = " + gameNum);
Console.WriteLine("Q2 = " + total_power);
