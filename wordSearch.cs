public int WordSearch(string content, string keyword)
{
	int amount = 0; //Sets the amount to zero.
	Parallel.For(0, content.Length, index =>
	{
		try //The try/catch block prevents the loop from going out of range.
		{
			string word = content.Substring(index, keyword.Length); //Takes in a word with the length of the keyword.
			if (word.Equals(keyword)) //Checks if word is a match of keyword
				amount++; //Increases the amount by 1.
		}
		catch {} //Nothing
	});
	return amount; //Returns the amount of keyword instances within content.
}
