namespace LeetCode;

public static class IsPalindromeQuest
{
    public static bool IsPalindrome(int x)
    {
        var numsChar = x.ToString().ToCharArray();

        for (var i = 0; i <= numsChar.Length / 2; i++)
        {
            if (numsChar[i] != numsChar[numsChar.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }

    //Copilot: 
    public static bool IsPalindromeCop(int x)
    {
        // Números negativos não são palíndromos
        if (x < 0)
        {
            return false;
        }

        // Obter o valor original para comparação posterior
        int original = x;
        int reversed = 0;

        // Reverter o número
        while (x > 0)
        {
            int digit = x % 10;
            reversed = reversed * 10 + digit;
            x /= 10;
        }

        // Comparar o número original com o número revertido
        return original == reversed;
    }


}
