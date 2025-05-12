using ByndyusoftSolution.Solution;

MethsSumTwoMinNumbers finder = new MethsSumTwoMinNumbers();

int[] numbers = new int[100];
Random rnd = new Random();

numbers[0] = -1; 
numbers[1] = -1;

for (int i = 2; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, int.MaxValue);
}

Console.WriteLine($"Answer: {numbers[0] + numbers[1]}. Result: {finder.SumTwoNumbersDijkstra(numbers)} ");