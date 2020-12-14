using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() { return "Hello, is this working friend friend!"; }

        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("/test")]
        public ActionResult Test()
        {
            return View();
        }
        [Route("/mad")]
        public ActionResult Mad(string noun, string pluralNoun, string verb, string verbTwo, string adjective, string adjectiveTwo, string pluralNounTwo, string adjectiveThree)
        {
            MadLibsVariable myMadLibs = new MadLibsVariable();
            myMadLibs.Noun = noun;
            myMadLibs.PluralNoun = pluralNoun;
            myMadLibs.Verb = verb;
            myMadLibs.VerbTwo = verbTwo;
            myMadLibs.Adjective = adjective;
            myMadLibs.AdjectiveTwo = adjectiveTwo;
            myMadLibs.PluralNounTwo = pluralNounTwo;
            myMadLibs.AdjectiveThree = adjectiveThree;
            return View(myMadLibs);

        }
        [Route("/form")]
        public ActionResult Form() { return View(); }
    }
}