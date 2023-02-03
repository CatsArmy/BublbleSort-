int[] bubble = new int[24];
Random random = new Random();
for (int i = 0; i < bubble.Length; i++)
{
    bubble[i] = random.Next(1,10350);
}
bool flag=true;
Console.WriteLine("do u want to display it across multipule lines?");
Console.WriteLine("0 = yes, no = 1");
int noNewLines = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Before Bubble Sorting");
Console.WriteLine(" ");
for (int i = 0; i < bubble.Length; i++)
{
	Console.Write($"{bubble[i]} index({i}), ");
	if (!flag && noNewLines == 1)
	{
		Console.WriteLine();
		flag = true;
	}
	else
	{
		flag = false;
	}
}
Console.WriteLine(" ");
Console.WriteLine("After Bubble Sorting");
Console.WriteLine(" ");
BubbleSort(bubble);
for (int i = 0; i < bubble.Length; i++)
{
    Console.Write($"{bubble[i]} index({i}), ");
    if (!flag && noNewLines == 1)
    {
        Console.WriteLine();
        flag = true;
    }
    else
    {
        flag = false;
    }
}
//Save the index of x value
//using that value make a temp value to swap the placement of them
static int[] BubbleSort(int[] bubble)
{ 
	int TempSort;
	int tempIndx;
	for (int i = 0; i < bubble.Length - 1; i++)
	{
		for (int j = 0; j < bubble.Length - 1; j++)
		{//brute force go brrrrrrrrrrr
			tempIndx = j + 1;
			TempSort = bubble[j];
			if (bubble[tempIndx] < bubble[j])
			{
				bubble[j] = bubble[tempIndx];
				bubble[tempIndx] = TempSort;
			}
		}
	}
	return bubble;
}