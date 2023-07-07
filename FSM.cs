public class FSM
{
    private int state;
    public bool CheckMonth(string month)
    {
        state = 1;
        foreach (var number in month)
        {
            if (!ProcessDigit(number))
            {
                return false;
            }
        }
        return true;
    }
    private bool ProcessDigit(char digit)
    {
        switch (state)
        {
            case 1:
                {
                    if (digit == '1')
                    {
                        state = 2;
                        return true;
                    }
                    if (digit >= '2' && digit <= '9')
                    {
                        state = 3;
                        return true;
                    }
                    return false;
                }
            case 2:
                if (digit == '0' || digit == '1' || digit == '2')
                {
                    return true;
                }
                return false;
            case 3:
                {
                    return false;
                }
        }
        throw new ArgumentException();
    }
}
