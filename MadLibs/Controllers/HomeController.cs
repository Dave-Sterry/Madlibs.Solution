using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/mad")]
        public ActionResult Mad()
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