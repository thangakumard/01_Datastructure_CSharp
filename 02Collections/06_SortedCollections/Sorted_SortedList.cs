

namespace Collections.Sorted
{

    [TestClass]
    public class Sorted_SortedList
    {
        [TestMethod]
        public void SortedSortedList(){
           SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(2, "Two");
            sortedList.Add(1, "One");

        }
    }
}