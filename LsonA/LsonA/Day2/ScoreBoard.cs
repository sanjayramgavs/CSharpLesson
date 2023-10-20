internal class ScoreBoard
{
     private static readonly ScoreBoard _board=new ScoreBoard();
     public int Score;
     private ScoreBoard() {
         Console.WriteLine("ScoreBoard Created..");
     }
     public static ScoreBoard GetScoreBoard()
     {
         return _board;
     }
}
public class TestScoreboard
{
     public static void TestOne()
     {
         ScoreBoard firstScoreBoard = ScoreBoard.GetScoreBoard();
         firstScoreBoard.Score = 220;
         ScoreBoard secondScoreBoard = ScoreBoard.GetScoreBoard();
         Console.WriteLine(secondScoreBoard.Score);
         Console.WriteLine(firstScoreBoard.Score);
     }
}