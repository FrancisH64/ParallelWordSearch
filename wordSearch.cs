public int WordSearch(string content, string keyword)
{
	int amount = 0; //Sets the amount to zero.
	Parallel.For(0, content.Length, index =>
	{
		if(content.Substring(index).Length >= keyword.Length) //Checks if the string is longer than the keyword, it keeps it bound.
		{
			string word = content.Substring(index, keyword.Length); //Takes in a word with the length of the keyword.
			if (word.Equals(keyword)) //Checks if word is a match of keyword
				amount++; //Increases the amount by 1.
		}
	});
	return amount; //Returns the amount of keyword instances within content.
}
