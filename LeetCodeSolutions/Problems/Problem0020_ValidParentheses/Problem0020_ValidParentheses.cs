namespace LeetCodeSolutions.Problems.Problem0020_ValidParentheses;

public static class Problem0020_ValidParentheses
{
    public static bool IsValid(string s)
    {
        if (s.Length < 2 || s[0] == ')' || s[0] == ']' || s[0] == '}')
        {
            return false;
        }

        Stack<int> pila = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                pila.Push(s[i]);
            }
            else if (s[i] == ')' && pila.Count > 0 && pila.Peek() == '(')
            {
                pila.Pop();
            }
            else if (s[i] == ']' && pila.Count > 0 && pila.Peek() == '[')
            {
                pila.Pop();
            }
            else if (s[i] == '}' && pila.Count > 0 && pila.Peek() == '{')
            {
                pila.Pop();
            }
            else
            {
                return false;
            }
        }

        return pila.Count == 0;
    }
}
