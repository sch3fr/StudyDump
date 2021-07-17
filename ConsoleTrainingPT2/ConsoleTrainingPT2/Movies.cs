using System;

public class Movie
{
	public string title;
	public string director;
	private string rating;
	public static int moviesCount = 0;	//Static class atribute is one that is assigned to whole class, not just single object

	public Movie(string aTitle, string aDirector, string aRating)
	{
		title = aTitle;
		director = aDirector;
		Rating = aRating;
		moviesCount++;
	}

	public string Rating
    {
		get
        {
			return rating;
        }
        set
        {
            if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
            {
				rating = value;
            }
			else
            {
				rating = "NR";
            }
        }
    }
}
