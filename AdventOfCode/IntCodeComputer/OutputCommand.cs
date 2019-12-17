using System;

namespace AdventOfCode.IntCodeComputer
{
    public class OutputCommand : ICommand
    {
        private int indexToWrite;

        public OutputCommand(int indexToWrite)
        {
            this.indexToWrite = indexToWrite;
        }

        public int Execute(int[] data)
        {
            Console.WriteLine("OUTPUT: " + data[indexToWrite]);
            return 2;
        }
    }
}