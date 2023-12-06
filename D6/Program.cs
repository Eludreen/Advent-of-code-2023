int T1 = 50;
int T2 = 74;
int T3 = 86;
int T4 = 85;
int TS1 = 242;
int TS2 = 1017;
int TS3 = 1691;
int TS4 = 1252;
int[] times = new int[4];
times[0] = T1;
times[1] = T2;
times[2] = T3;
times[3] = T4; 
int[] speeds = new int[4];
speeds[0] = TS1;
speeds[1] = TS2;
speeds[2] = TS3;
speeds[3] = TS4;
int total = 1;

//Q1
for (int i = 0; i < 4; i++)
{
    int combi = 0;
    for (int j = 0; j < times[i]; j++)
    {
        int speed = j;
        int distanceTravelled = (times[i] - j) * j;
        if (distanceTravelled > speeds[i])
        {
            combi++;
        }
    }
    total = total * combi;
    Console.WriteLine(combi);
}
Console.WriteLine("Q1" + total);


//Q2
Int64 time = 50748685;
Int64 bigDist = 242101716911252;
int combination = 0;
for (int j = 0; j < time; j++)
{
    Int64 distanceTravelled = (time - j) * j;
    if (distanceTravelled > bigDist)
    {
        combination++;
    }
}
Console.WriteLine("Q2" + combination);