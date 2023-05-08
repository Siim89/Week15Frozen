
List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2], tempArray[1]);
    myMovies.Add(newMovie);
}
foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.Rating: {movie.Rating}");
}
static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Data\movies.txt";
    return File.ReadAllLines(filePath);
}
class Movie
{
    string title;
    string year;
    string rating;
    public string Title
    {
        get { return title; }
    }
    public string Year
    {
        get { return year; }
    }
    public string Rating
    {
        get { return rating; }
        }

             public Movie(string _title, string _year,string _rating)
    {
        title = _title;
        year = _year;
        rating = _rating;
    }
}



/*List<SecretSanta> myGifts = new List<SecretSanta>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
    SecretSanta newGift = new SecretSanta(tempArray[0], tempArray[1]);
    myGifts.Add(newGift);
}

foreach(SecretSanta gift in myGifts)
{
    Console.WriteLine($"{gift.Name} wants {gift.GiftWish}");
}
static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Data\frozen.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}
class SecretSanta
{
    string name;
    string giftWish;


    public SecretSanta(string _name, string _giftWish)
    {
        name = _name;
        giftWish = _giftWish;
    }

    public string Name
    {
        get { return name; }
    }

    public string GiftWish
    { 
        get { return giftWish; }
    }
}
*/