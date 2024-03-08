using System.Collections;
using System.ComponentModel.Design;
using System.Data;
using System.Security.Cryptography;
using System.Xml.XPath;

class LetterCombinationsPhoneNumber
{
    List<string> combinations = new List<string>();

    public Dictionary<char, List<char>> options = new Dictionary<char, List<char>> {
        {'2', ['a', 'b', 'c']},
        {'3', ['d', 'e', 'f']},
        {'4', ['g', 'h', 'i']},
        {'5', ['j', 'k', 'l']},
        {'6', ['m', 'n', 'o']},
        {'7', ['p', 'q', 'r', 's']},
        {'8', ['t', 'u', 'v']},
        {'9', ['w', 'x', 'y', 'z']}
    };

    public void AddFirstWordInList(List<char> letters)
    {
        foreach (char letter in letters)
        {
            this.combinations.Add(letter.ToString());
        }
    }

    public void CombineWithOtherWords(List<char> newWord)
    {
        List<string> result = new List<string>();
        foreach (string combination in this.combinations)
        {
            foreach (char word in newWord)
            {
                result.Add((combination + word).ToString());
            }
        }
        this.combinations = result;
    }
    public List<string> ShowCombinations(string digits)
    {
        List<List<char>> lettersToCombination = getLettersToCombination(digits);

        foreach (List<char> letters in lettersToCombination)
        {
            if (combinations.Count == 0)
            {
                this.AddFirstWordInList(letters);
            }  
            else 
            {
                this.CombineWithOtherWords(letters);
            }
        }
        return this.combinations;
    }

    private List<List<char>> getLettersToCombination(string digits)
    {
        List<List<char>> lettersDigited = new List<List<char>>();
        foreach (char digit in digits.ToCharArray())
        {
            List<char> letters = this.options[digit];
            lettersDigited.Add(letters);

        }
        return lettersDigited;
    }
}