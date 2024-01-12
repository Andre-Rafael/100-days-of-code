public class IsJohnnyMakingProgress
{
    public int ProgressDays(int[] milesRunned)
    {
        int progress = 0;
        for (int i = 0; i < milesRunned.Length; i++)
        {
            if (i == 0)
            {
                continue;
            }
            else if (milesRunned[i - 1] < milesRunned[i])
            {
                progress += 1;
            }
        }
        return progress;
    }
}