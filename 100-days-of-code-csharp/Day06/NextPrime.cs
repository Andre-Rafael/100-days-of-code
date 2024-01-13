class NextPrime
{
    bool isNotPrime(int num)
    {
        bool dividedBy2 = num % 2 == 0;
        bool dividedBy3 = num % 3 == 0;
        bool dividedBy5 = num % 5 == 0;
        bool dividedBy7 = num % 7 == 0;

        return dividedBy2 || dividedBy3 || dividedBy5 || dividedBy7;
    }
    public int nextPrime (int num)
    {
        while (this.isNotPrime(num))
        {
            num += 1;
        }
        return num;
    }
}