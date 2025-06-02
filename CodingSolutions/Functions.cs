namespace CodingSolutions
{
	public static class Functions
	{
		/// <summary>
		/// Prints the number of occurrences for each non-space character in the sentence.
		/// Ignores spaces and outputs the count for each character to the console.
		/// </summary>
		/// <param name="sentence">The input string to analyze.</param>
		public static void PrintLetterOccurrencesInString(this string sentence)
		{
			Dictionary<char, int> charCount = new Dictionary<char, int>();

			for (int i = 0; i < sentence.Length; i++)
			{
				if (charCount.ContainsKey(sentence[i]))
				{
					charCount[sentence[i]]++;    // Increment if char already exists
				}
				else
				{
					if (sentence[i] != ' ')  // Add if char does not exist and is not a space
						charCount.Add(sentence[i], 1);
				}
			}

			foreach (var item in charCount)
			{
				Console.WriteLine($"Letter {item.Key} occured {item.Value} time(s).");
			}
		}
	}
}