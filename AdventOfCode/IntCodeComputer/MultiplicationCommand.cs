namespace AdventOfCode.IntCodeComputer
{
    public class MultiplicationCommand : ICommand
    {
        private readonly int firstOperand;
        private readonly int secondOperand;
        private readonly int outputIndex;

        public MultiplicationCommand(int firstOperand, int secondOperand, int outputIndex)
        {
            this.firstOperand = firstOperand;
            this.secondOperand = secondOperand;
            this.outputIndex = outputIndex;
        }

        public int Execute(int[] data)
        {
            data[outputIndex] = firstOperand * secondOperand;
            return 4;
        }
    }
}