using System.Text;

namespace Task2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			int[] input = { 1, 2, 3, 4, 4, 56 };
			int[] temp = new int[input.Length];
			int counterTemp = 0;
			temp[counterTemp] = input[0];
			
			for (int i = 1; i < input.Length; i++)
			{
				if (input[i - 1] == input[i])
				{
					continue;
				}
				else 
				{
					counterTemp++;
					temp[counterTemp] = input[i];
				}
			}

			int[] output = new int[counterTemp + 1];
			Array.Copy(temp, output, counterTemp + 1);

			foreach (int i in output)
			{
				Console.WriteLine(i);
			}
			Console.ReadKey();
		}
	}
}
