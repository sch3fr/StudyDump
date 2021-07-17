using System;

public class MyFirstClass
{
	public string title; //  <- class atributes
	public string author;
	public int pages;
	
	public MyFirstClass(string aTitle, string aAuthor, int aPages) //  <- constructor; a for argument => arugmentAuthor
	{
		title = aTitle;
		author = aAuthor;
		pages = aPages;
		Console.WriteLine("Creating book");
	}

	public bool IsLong() //  <- object method
    {
		if (pages > 400)
        {
			return true;
        }
		return false;
    }
}
