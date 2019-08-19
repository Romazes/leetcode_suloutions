/* Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
*
*  An input string is valid if:
*
*  Open brackets must be closed by the same type of brackets.
*  Open brackets must be closed in the correct order.
*  Note that an empty string is also considered valid.
*
*  Input: "()[]{}"
*  Output: true
*
*  Input: "([)]"
*  Output: false
* 
*/

/********** First attempt **********/
 public bool IsValid(string s) {
  var stack = new Stack<char>();
  foreach (var e in s)
  {
    switch (e)
    {
      case '[':
      case '(':
      case '{':
        stack.Push(e);
        break;
      case ']':
        if (stack.Count == 0) return false;
        if (stack.Pop() != '[') return false;
        break;
          case ')':
            if (stack.Count == 0) return false;
            if (stack.Pop() != '(') return false;
              break;
           case '}':
            if (stack.Count == 0) return false;
            if (stack.Pop() != '{') return false;
            break;
           default:
            return false;
    }
  }
  return stack.Count == 0;
}

/********** Second attempt **********/
public static bool IsCorrectString1(string str)
{
    var pairs = new Dictionary<char, char>();
    pairs.Add('(', ')');
    pairs.Add('[', ']');
    //Here add new Brackets
    var stack = new Stack<char>();
    foreach (var e in str)
    {
        if (pairs.ContainsKey(e)) stack.Push(e);
        else if (pairs.ContainsValue(e))
        {
            if (stack.Count == 0 || pairs[stack.Pop()] != e) return false;
        }
        else return false;
    }
    return stack.Count == 0;
}
