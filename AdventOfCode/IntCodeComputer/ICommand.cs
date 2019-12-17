namespace AdventOfCode.IntCodeComputer
{
    public interface ICommand
    {
        int Execute(int[] data);
    }
}