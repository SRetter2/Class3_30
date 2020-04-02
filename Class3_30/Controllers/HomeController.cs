using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class3_30.Models;

namespace Class3_30.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Results(string text)
        {
            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            string abc = "abcdefghijklmnopqrstuvwxyz";
            foreach (char c in abc)
            {
                alphabet[c] = 0;
            }
            string searchText = text.ToLower();
            foreach (char c in searchText)
            {
                if (alphabet.ContainsKey(c))
                {
                    alphabet[c]++;
                }
            }
            ResultsViewModel vm = new ResultsViewModel
            {
                Abc = "abcdefghijklmnopqrstuvwxyz",
                Alphabet = alphabet,
                Text = text
            };
            
            return View(vm);
        }

    }
}
