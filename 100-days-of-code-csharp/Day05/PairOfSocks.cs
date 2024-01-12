public class PairOfSocks
{
    public int SockPairs(string sequence)
    {
        int pairs = 0;
        IDictionary<string, int> socks = new Dictionary<string, int>();
        SepareSocks(sequence, socks);
        pairs = CountPairs(pairs, socks);
        return pairs;
    }

    private static int CountPairs(int pairs, IDictionary<string, int> socks)
    {
        foreach (var item in socks)
        {
            bool containsPairs = item.Value % 2 == 0;
            if (containsPairs)
            {
                pairs += item.Value / 2;
            }
        }

        return pairs;
    }

    private static void SepareSocks(string sequence, IDictionary<string, int> socks)
    {
        for (int i = 0; i < sequence.Length; i++)
        {
            string key = sequence[i].ToString();
            if (socks.ContainsKey(key))
            {
                socks[key] += 1;
            }
            else
            {
                socks.Add(key, 1);
            }
        }
    }
}