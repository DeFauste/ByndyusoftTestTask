using ByndyusoftSolution.Solution;
using System.Diagnostics;
using Xunit;


namespace ByndyusoftSolution.Facts
{
    public class DijkstrUnitTest
    {
        private MethsSumTwoMinNumbers finder = new MethsSumTwoMinNumbers();
        [Fact]
        public void FactSumOfTwoMinNumbers_NormalCase()
        {
            int[] numbers = { 4, 0, 3, 19, 492, -10, 1 };

            var sw = Stopwatch.StartNew();

            int result = finder.SumTwoNumbersDijkstra(numbers);

            sw.Stop();

            Assert.Equal(-10, result);
            Debug.WriteLine($"Normal Case execution time: {sw.ElapsedMilliseconds} ms");
        }
        [Fact]
        public void SumOfTwoMinNumbers_AllPositiveNumbers_ReturnsCorrectSum()
        {           
            int[] numbers = { 5, 2, 8, 1, 3 };

            var sw = Stopwatch.StartNew();

            int result = finder.SumTwoNumbersDijkstra(numbers);

            sw.Stop();

            Assert.Equal(3, result);
            Debug.WriteLine($"Positive Numbers execution time: {sw.ElapsedMilliseconds} ms");
        }

        [Fact]
        public void SumOfTwoMinNumbers_AllNegativeNumbers_ReturnsCorrectSum()
        { 
            int[] numbers = { -5, -2, -8, -1, -3 };

            var sw = Stopwatch.StartNew();

            int result = finder.SumTwoNumbersDijkstra(numbers);

            sw.Stop();

            Assert.Equal(-13, result);
            Debug.WriteLine($"All NegativeNumbers execution time: {sw.ElapsedMilliseconds} ms");

        }

        [Fact]
        public void SumOfTwoMinNumbers_DuplicateValues_ReturnsCorrectSum()
        {             
            int[] numbers = { 1, 1, 1, 1, 1 };

            var sw = Stopwatch.StartNew();

            int result = finder.SumTwoNumbersDijkstra(numbers);

            sw.Stop();

            Assert.Equal(2, result);
            Debug.WriteLine($"Duplicate Values execution time: {sw.ElapsedMilliseconds} ms");
        }

        [Fact]
        public void SumOfTwoMinNumbers_LargeArray_ReturnsCorrectSum()
        { 
            int[] numbers = new int[1000000];
            numbers[0] = -1000;
            numbers[1] = -2000;
            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }


            var sw = Stopwatch.StartNew();

            int result = finder.SumTwoNumbersDijkstra(numbers);

            sw.Stop();

            Assert.Equal(-3000, result);
            Debug.WriteLine($"Large Array execution time: {sw.ElapsedMilliseconds} ms");
        }

        [Fact]
        public void SumOfTwoMinNumbers_EmptyArray_ThrowsArgumentException()
        {
             
            int[] numbers = Array.Empty<int>();

             
            Assert.Throws<ArgumentException>(() => finder.SumTwoNumbersDijkstra(numbers));
        }

        [Fact]
        public void SumOfTwoMinNumbers_SingleElementArray_ThrowsArgumentException()
        {
             
            int[] numbers = { 5 };

             
            Assert.Throws<ArgumentException>(() => finder.SumTwoNumbersDijkstra(numbers));
        }

        [Fact]
        public void SumOfTwoMinNumbers_NullArray_ThrowsArgumentException()
        {
             
            int[] numbers = null;

             
            Assert.Throws<ArgumentException>(() => finder.SumTwoNumbersDijkstra(numbers));
        }

        //[Fact]
        //public void SumOfTwoMinNumbers_MegaLargeArray_ReturnsCorrectSum()
        //{
        //    int[] numbers = new int[100000000];
        //    numbers[0] = -1000;
        //    numbers[1] = -2000;
        //    for (int i = 2; i < numbers.Length; i++)
        //    {
        //        numbers[i] = i;
        //    }
        //
        //
        //    var sw = Stopwatch.StartNew();
        //
        //    int result = finder.SumTwoNumbersDijkstra(numbers);
        //
        //    sw.Stop();
        //
        //    Assert.Equal(-3000, result);
        //    Debug.WriteLine($"Mega Large Array execution time: {sw.ElapsedMilliseconds} ms");
        //}
    }
}
