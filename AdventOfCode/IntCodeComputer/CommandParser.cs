using System;

namespace AdventOfCode.IntCodeComputer
{
    public static class CommandParser
    {
        public static ICommand ParseCommand(int[] data, int i, int input)
        {
            if (data[i] == 1)
            {
                return new SumCommand(data[data[i + 1]], data[data[i + 2]], data[i + 3]);
            }
            if (data[i] == 2)
            {
                return new MultiplicationCommand(data[data[i + 1]], data[data[i + 2]], data[i + 3]);
            }
            if (data[i] == 3)
            {
                return new InputCommand(input, data[i + 1]);
            }
            if (data[i] == 4)
            {
                return new OutputCommand(data[i+1]);
            }
            if (data[i] == 99)
            {
                return new ExitCommand();
            }
            else
            {
                return ParseComplexCommand(data, i, input);
            }
        }

        private static ICommand ParseComplexCommand(int[] data, in int i, in int input)
        {
            var command = data[i].ToString().PadLeft(4, '0');

            if (command[2..4] == "01")
            {
                var firstOperand = command[1] == '1' ? data[i + 1] : data[data[i + 1]];
                var secondOperand = command[0] == '1' ? data[i + 2] : data[data[i + 2]];
                return new SumCommand(firstOperand, secondOperand, data[i+3]);
            }
            if (command[2..4] == "02")
            {
                var firstOperand = command[1] == '1' ? data[i + 1] : data[data[i + 1]];
                var secondOperand = command[0] == '1' ? data[i + 2] : data[data[i + 2]];
                return new MultiplicationCommand(firstOperand, secondOperand, data[i+3]);
            }
            if (command[2..4] == "03")
            {
                if (command[1] == '1')
                {
                    Console.WriteLine("OLOLO");
                }
                var indexToWrite = command[1] == '1' ? i+1 : data[i + 1];
                return new InputCommand(input, indexToWrite);
            }
            if (command[2..4] == "04")
            {
                if (command[1] == '1')
                {
                    Console.WriteLine("OLOLO");
                }
                var indexToRead = command[1] == '1' ? i+1 : data[i + 1];
                return new OutputCommand(indexToRead);
            }

            return new ExitCommand();
        }
    }
}