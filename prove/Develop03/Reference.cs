
public class Reference
{
    private string book;
    private int chapter;
    private  int StartVerse;
    private int EndVerse;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.StartVerse = verse;
        this.EndVerse = verse;
    }

    public Reference(string book, int chapter, int StartVerse, int EndVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.StartVerse = StartVerse;
        this.EndVerse = EndVerse;
    }

    public string FormattedReference()
    {
        if (StartVerse == EndVerse)
        return $"{book}, {chapter}:{StartVerse}";
        else 
        return $"{book}, {chapter}:{StartVerse}-{EndVerse}";
    }
}