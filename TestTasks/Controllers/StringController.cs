using Microsoft.AspNetCore.Mvc;
using TestTasks.Services;

namespace TestTasks.Controllers
{
    public class StringController
    {
        public bool IsPalindrome([FromServices] PalindromeService palindromeService, string str)
        {
            return palindromeService.IsPalindrome(str);
        }
    }
}
