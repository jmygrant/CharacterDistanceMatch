using System;

namespace CharacterMatchSum
{
    class Program
    {
        static void Main(string[] args)
        {
			int result = CharacterMismatchSum("cat", "at");
			Console.WriteLine(string.Format("{0}", result));

			result = CharacterMismatchSum("boat", "got");
			Console.WriteLine(string.Format("{0}", result));

			result = CharacterMismatchSum("though", "sloughs");
			Console.WriteLine(string.Format("{0}", result));

			Console.ReadLine();
        }

		public static int CharacterMismatchSum(string str1, string str2)
		{
			int sum = 0;
			string mergeString = str1;

			for(int i = 0; i < str2.Length; i++)
			{
				if(mergeString.Contains(str2[i].ToString()))
				{
					int index = mergeString.IndexOf(str2[i]);
					mergeString = mergeString.Remove(index, 1);
				}
				else
				{
					mergeString += str2[i];
				}
			}

			for(int i = 0; i<mergeString.Length; i++)
			{
				sum += Convert.ToInt32(mergeString[i]);
			}

			return sum;
		}
    }
}
