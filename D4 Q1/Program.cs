string path = "input.txt.txt";
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
    return (lineCount);
}
bool splitter = true;
int lineCount = (LineCount(path));
string winners = "";
string reality = "";
double totalScore = 0;
using (var sr = new StreamReader(path))
{
    for (int i = 0; i < lineCount; i++)
    {
        winners = null;
        reality = null;
        splitter = true;
        double score = 0.5;
        string line = sr.ReadLine();
        for (int x = 0; x < (line.Length); x++)
        {
            string check = line[x].ToString();
            if (splitter)
            {
                if (check == "|")
                {
                    splitter = false;
                }
                else
                {
                    winners += check;
                    splitter = true;
                }
            }
            else
            {
                reality += check;
            }
        }
        string[] removing = (winners.Split(":"));
        winners = removing[1];
        string[] bigWinners = (winners.Split(" "));
        string[] bigReal = (reality.Split(" "));
        bigWinners = bigWinners;
        //string[] bigWinners2 = new string[(bigWinners.Length)];
        //string[] bigReal2 = new string[(bigReal.Length)];
        List<string> bigReal2 = new List<string>();
        for (int z = 0; z < (bigReal.Length); z++)
        {
            string transfer = (bigReal[z]);
            if (transfer != "")
            {
                bigReal2.Add(transfer);
            }
        }
        List<string> bigWinners2 = new List<string>();
        for (int z = 0; z < (bigWinners.Length); z++)
        {
            string transfer = (bigWinners[z]);
            if (transfer != "")
            {
                bigWinners2.Add(transfer);
            }
        }
        foreach (string s in bigReal2)
        {
            string trimmed = s.Trim();
            //Console.WriteLine(trimmed);
            int real = int.Parse(trimmed);
            foreach (string x in bigWinners2)
            {
                //Console.Write(x + ",");
                string trimmed2 = x.Trim();
                int winner = int.Parse(trimmed2);
                if (s == x)
                {
                    score = score * 2;
                    //Console.Write(score);
                    //Console.WriteLine();
                }
            }
            //Console.WriteLine();
        }
        if (score == 0.5)
        {
            score = 0;
        }
        totalScore += score;
    }
}
Console.WriteLine(totalScore);