// CREATIVITY:
// 1. Level System: Every 1000 points = +1 Level. Displayed as "Level X Ninja Unicorn"
// 2. Bonus message when ChecklistGoal is completed
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}