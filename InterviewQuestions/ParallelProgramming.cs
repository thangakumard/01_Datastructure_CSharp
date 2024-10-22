
namespace InterviewQuestions
{

    [TestClass]
    public class ParallelProgramming
    {
        [TestMethod]
        public void sum(){
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            long sum = 0;
            Parallel.ForEach(numbers, num =>
            {
                sum += num;
            });
            Console.WriteLine("Sum: " + sum);
        }
    }
}