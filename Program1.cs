int[] nums = new int[7];
Console.WriteLine("Введите семь чисел");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write("{0}-е число: ", i + 1);
    nums[i] = Int32.Parse(Console.ReadLine());
}

int max = nums[0];
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] > max)
        max = nums[i];
}

int[] count = new int[max + 1];


for (int i = 0; i < nums.Length; i++)
{
    count[nums[i]]++;
}


int index = 0;
for (int i = max; i >= 0; i--)
{
    while (count[i] > 0)
    {
        nums[index++] = i;
        count[i]--;
    }
}

Console.WriteLine("Вывод отсортированного массива по убыванию");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
Console.ReadLine();