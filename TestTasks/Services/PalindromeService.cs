namespace TestTasks.Services
{
    public class PalindromeService
    {
        public bool IsPalindrome (string str)
        {
            return Enumerable.Range(0, str.Length / 2).All(symbol => str[symbol] == str[str.Length - 1 - symbol]);
        }
    }
}
