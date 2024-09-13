namespace PriorityQueue;

[TestClass]
public class PriorityQueue01_KthWinner
{
    [TestMethod]
    public void KthWinner()
    {
       List<string> winners = new List<string>();
       winners.Add("player1, 60");
       winners.Add("player2, 100");
       winners.Add("player3, 60");
       winners.Add("player4, 40");
       winners.Add("player5, 30");
       Assert.AreEqual(60, FindKthLargest(winners, 2));
    }

    private int FindKthLargest(List<string> winners, int k) {
        
        Dictionary<int, List<string>> dictBoard = new Dictionary<int, List<string>>();
        foreach(string scoreInfo in winners){
            string[] input = scoreInfo.Split(',');
            string payler = input[0];
            int score = Convert.ToInt32(input[1]);

           List<string> lstPaylers = new List<string>();
           if(!dictBoard.ContainsKey(score)){
                dictBoard.Add(score, lstPaylers);
           }
           lstPaylers.Add(payler);
           dictBoard[score] = lstPaylers;
        } 

        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();

        foreach(KeyValuePair<int, List<string>> entry in dictBoard){
            queue.Enqueue(entry.Key, entry.Key);
            if(queue.Count > k){
                queue.Dequeue();
            }
        }
        return queue.Peek();
    }
}
