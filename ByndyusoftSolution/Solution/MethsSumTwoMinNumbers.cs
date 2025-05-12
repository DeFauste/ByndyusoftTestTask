
namespace ByndyusoftSolution.Solution
{
    public class MethsSumTwoMinNumbers
    {
        /// <summary>
        /// Метод получения суммы двух чисел, который использует быструю сортировку Дейкстра, написанную вручную
        /// </summary>
        public int SumTwoNumbersDijkstra(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                throw new ArgumentException($"Array {nameof(numbers)} must contain at least 2 elements.");
            }

            if (numbers.Length == 2)
            {
                return numbers[0] + numbers[1];
            }
            int[] sorted = numbers.SortedDijkstra(true);

            return sorted[0] + sorted[1];
        }
        /// <summary>
        /// Метод получения суммы двух чисел, который использует LINQ
        /// </summary>
        public int SumTwoNumbersLINQ(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                throw new ArgumentException($"Array {nameof(numbers)} must contain at least 2 elements.");
            }

            var sorted = numbers.OrderBy(x => x).Take(2).ToArray();
            return sorted[0] + sorted[1];
        }
    }
}
