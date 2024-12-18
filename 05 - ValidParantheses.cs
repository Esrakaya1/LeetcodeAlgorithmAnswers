public class Solution
{
    public bool IsValid(string s)
    {
        // 1. solution
        //   while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        //     {
        //         s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        //     }
        //     return s.Length == 0;


        // Second solution
        Dictionary<char, char> bracketsMap = new Dictionary<char, char>{
            {'{',  '}'},
            {'(',  ')'},
            {'[',  ']'},
        };
        Stack<char> openBrackets = new Stack<char>();

        foreach (char bracket in s)
        {
            if (bracketsMap.ContainsKey(bracket))
            {
                openBrackets.Push(bracket);
            }
            else
            {
                if (openBrackets.Count == 0)
                {
                    return false;
                }
                if (bracketsMap[openBrackets.Pop()] == bracket)
                {
                    continue;
                };
                return false;
            }
        }
        return openBrackets.Count == 0;
    }
}


// JavaScript solution
// Explanation
// Here is the step-by-step approach of the algorithm:

// Initialize an empty stack.

// Traverse the input string character by character.

// If the current character is an opening bracket (i.e., '(', '{', '['), push it onto the stack.

// If the current character is a closing bracket (i.e., ')', '}', ']'), check if the stack is empty. If it is empty, return false, because the closing bracket does not have a corresponding opening bracket. Otherwise, pop the top element from the stack and check if it matches the current closing bracket. If it does not match, return false, because the brackets are not valid.

// After traversing the entire input string, if the stack is empty, return true, because all opening brackets have been matched with their corresponding closing brackets. Otherwise, return false, because some opening brackets have not been matched with their corresponding closing brackets.

// Complexity
// Time complexity:
// The time complexity of the solution is O(n), where n is the length of the input string. This is because we traverse the string once and perform constant time operations for each character.

// Space complexity:
// The space complexity of the solution is O(n), where n is the length of the input string. This is because the worst-case scenario is when all opening brackets are present in the string and the stack will have to store them all.

/**
 * @param {string} s
 * @return {boolean}
 */
// var isValid = function(s) {
//     let stack = []; // create an empty stack to store opening brackets
//     for (let c of s) { // loop through each character in the string
//         if (c === '(' || c === '{' || c === '[') { // if the character is an opening bracket
//             stack.push(c); // push it onto the stack
//         } else { // if the character is a closing bracket
//             if (!stack.length || // if the stack is empty or 
//                 (c === ')' && stack[stack.length - 1] !== '(') || // the closing bracket doesn't match the corresponding opening bracket at the top of the stack
//                 (c === '}' && stack[stack.length - 1] !== '{') ||
//                 (c === ']' && stack[stack.length - 1] !== '[')) {
//                 return false; // the string is not valid, so return false
//             }
//             stack.pop(); // otherwise, pop the opening bracket from the stack
//         }
//     }
//     return !stack.length; // if the stack is empty, all opening brackets have been matched with their corresponding closing brackets,
//                           // so the string is valid, otherwise, there are unmatched opening brackets, so return false
// };