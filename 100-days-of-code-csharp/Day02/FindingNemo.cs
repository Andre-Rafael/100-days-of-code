public class FindingNemo
{
    public string findNemo (string phrase)
    {
        string[] words = phrase.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == "Nemo")
            {
                return String.Format("I found Nemo at {0}!", i + 1);
            }
        }
        return "I can't find Nemo :(";
    }
}