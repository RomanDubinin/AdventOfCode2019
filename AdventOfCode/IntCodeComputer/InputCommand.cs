namespace AdventOfCode.IntCodeComputer
{
    public class InputCommand : ICommand
    {
        private readonly int input;
        private readonly int indexToWrite;

        public InputCommand(int input, int indexToWrite)
        {
            this.input = input;
            this.indexToWrite = indexToWrite;
        }

        public int Execute(int[] data)
        {
            data[indexToWrite] = input;
            return 2;
        }
    }
}