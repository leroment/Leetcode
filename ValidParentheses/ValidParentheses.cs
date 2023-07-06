public class Solution {
    public bool IsValid(string s) {

        if (s.Length % 2 != 0)
        {
            return false;
        }

        Stack<char> brackets = new Stack<char>();

        for (int i = 0; i < s.Length ; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                brackets.Push(s[i]);
            }

            if (brackets.Count() == 0)
            {
                return false;
            }

            if (s[i] == ')')
            {
                var bracket = brackets.Peek();

                if (bracket == '(')
                {
                    brackets.Pop();
                } else 
                {
                    return false;
                }
            }

            if (s[i] == '}')
            {
                var bracket = brackets.Peek();

                if (bracket == '{')
                {
                    brackets.Pop();
                } else 
                {
                    return false;
                }
            }

            if (s[i] == ']')
            {
                var bracket = brackets.Peek();

                if (bracket == '[')
                {
                    brackets.Pop();
                } else
                {
                    return false;
                }
            }
        }

        if (brackets.Count() == 0)
        {
            return true;
        }
        
        return false;
    }
}