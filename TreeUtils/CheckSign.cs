namespace TreeUtils
{
    public class CheckSign
    {
        public int Sign;

        public CheckSign(char _Sign)
        {
            char e = _Sign;

            if (e == '!' || e == '@' || e == '#' || e == '$' || e == '%' || e == '^' || e == '&' || e == '*' || e == ')')
            {
                return;
            }
            else
            {
                Console.WriteLine("oszukujesz, zamykam się i nie gadam z Tobą!");
            }

        }

    }
}