
public class Scripture
{
   private Reference scriptureReference;
   private string text;
   private List<Word> words;

   public Scripture(Reference scriptureReference, string text)
   {
    this.scriptureReference = scriptureReference;
    this.text = text;
    InitializeWords();
   }

   private void InitializeWords()
   {
    string[] wordArray = text.Split(new char[] {' ',',','.',';',':'}, StringSplitOptions.RemoveEmptyEntries);

    words =new List<Word>();
    foreach (var word in wordArray)
    {
      words.Add(new Word(word));
    }

   }

   public void DisplayCompleteScripture()
   {
     Console.WriteLine($"Scripture Reference: {scriptureReference.FormattedReference()}"); 
     Console.WriteLine("Complete Scripture:");
     foreach(var word in words)
     {
      Console.Write($"{word} ");
     }
     Console.WriteLine();
   }
   public void HideWords()
   {
      Random random = new Random();
      int numWordsToHide = random.Next(1, words.Count / 2);
      for (int i = 0; i < numWordsToHide; i++)
      {
         Word wordToHide;
         do
         {
            wordToHide = words[random.Next(0, words.Count)];
         } while (wordToHide.IsHidden());

         wordToHide.Hide();
      }
   }

   public bool AllWordsHidden()
   {
      return words.All(word => word.IsHidden());
   }
}