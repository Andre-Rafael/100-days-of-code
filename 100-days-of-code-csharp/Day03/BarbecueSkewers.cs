public class BarbecueSkewers
{
    public string SepareSkewers(string[] skewers)
    {
        int meat = 0;
        int vegetarian = 0;
        foreach (var skewer in skewers)
        {
            if (skewer.Contains("-x"))
            {
                meat += 1;
            }
            else
            {
                vegetarian += 1;
            }
        }
        return "[" + vegetarian + ", " + meat + "]";
    }
}