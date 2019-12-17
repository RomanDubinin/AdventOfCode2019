namespace AdventOfCode.IntCodeComputer
{
    public class ExitCommand : ICommand
    {
        public int Execute(int[] data)
        {
            return -1;
        }
    }
}