namespace LeetCodeSolutions.Problems.Problem0014_LongestCommonPrefix;

public static class Problem0014_LongestCommonPrefix
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return string.Empty;
        }

        if (strs?.Length == 1)
        {
            return strs[0];
        }

        short repeticiones = 0;
        string prefix = string.Empty;
        bool iterar = true;

        int i = 0;
        char letra = new();

        do
        {
            if (strs[i].Length != 0 &&
                strs[i].Length > repeticiones &&
                (letra == '\0' || (letra != '\0' && strs[i][repeticiones] == letra)))
            {
                letra = strs[i][repeticiones];
            }
            else
            {
                letra = '\0';
                iterar = false;
            }

            i++;

            if (i == strs.Length)
            {
                i = 0;
                repeticiones++;
                prefix += letra != '\0' ? letra : "";
                letra = new();
            }

        } while (iterar);

        return prefix;
    }
}
