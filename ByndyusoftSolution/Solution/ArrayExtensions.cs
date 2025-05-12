using System;


namespace ByndyusoftSolution.Solution
{
    public static class ArrayExtensions
    {
        public static int SumTwoNumbers(this int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                throw new ArgumentException($"Array {nameof(numbers)} must contain at least 2 elements.");
            }

            if(numbers.Length == 2)
            {
                return numbers[0] + numbers[1];
            }

            int[] sorted = numbers.SortedDijkstra(true);

            return sorted[0] + sorted[1];            
        }

        public static int[] SortedDijkstra(this int[] array, bool safe)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int[] sorted;

            if(safe)
            {
                sorted = new int[array.Length];
                Array.Copy(array, sorted, array.Length);
            } else
            {
                sorted = array;
            }

            QuickSort(sorted);

            return sorted;
        }
        private  static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int lo, int hi)
        {
            if (lo >= hi)
            {
                return;
            }
            int[] part = BreakPartition(array, lo, hi);
           QuickSort(array, lo, part[0] - 1);
           QuickSort(array, part[1] + 1, hi);
        }
        private static int[] BreakPartition(int[] array, int lo, int hi)
        {
            int i = lo + 1;
            int lt = lo;
            int gt = hi;
            int supportElement = array[lo];
            for (; i <= gt;)
            {
                if (array[i] < supportElement)
                {
                    Swap(array, i, lt);
                    i += 1;
                    lt += 1;
                }
                else if (array[i] > supportElement)
                {
                    Swap(array, i, gt);
                    gt -= 1;
                }
                else
                {
                    i += 1;
                }
            }
            return new int[] { lt, gt };
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
