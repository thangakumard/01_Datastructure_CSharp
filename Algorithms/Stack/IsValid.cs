
using System;
using System.Collections;

namespace StackAlgorithms
{

    [TestClass]
    public class IsValid
    {
        [TestMethod]
        public void IsValidParentheses()
        {
            Assert.AreEqual(true, IsValidParentheses1("([{}])"));
            Assert.AreEqual(false, IsValidParentheses1("["));
        }
        public bool IsValidParentheses1(string s) {
            Stack<Char> stack = new Stack<Char>();

        foreach(char c in s){
            if(c == '('){
                stack.Push(')');
            }
            else if(c == '{'){
                stack.Push('}');
            }
             else if(c == '['){
                stack.Push(']');
            }else{
                if(stack.Count > 0){
                    char x = stack.Pop();
                    if(x != c) return false;
                }else return false;
            }
        }

        return stack.Count() == 0;
        }
    }
}