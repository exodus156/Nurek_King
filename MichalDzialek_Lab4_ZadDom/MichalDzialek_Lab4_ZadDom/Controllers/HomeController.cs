using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MichalDzialek_Lab4_ZadDom.Models;

namespace MichalDzialek_Lab4_ZadDom.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Listy dla poszczególnych kategorii sprzętowych
        /// </summary>
        List<ObjectTemplateModel> automaty;
        List<ObjectTemplateModel> boje;
        List<ObjectTemplateModel> butle;
        List<ObjectTemplateModel> kamizelki;
        List<ObjectTemplateModel> skafandry;

        /// <summary>
        /// Konstruktor list
        /// </summary>
        public HomeController()
        {
            this.automaty = new List<ObjectTemplateModel>();
            automaty.Add(new ObjectTemplateModel("Omen", "Automat oddechowy", "Najtańsza i najprostrza wersja aparatu oddechowego do nurkowania", 1200, "~/images/Aut.Oddech/1.jpg", "a1"));
            automaty.Add(new ObjectTemplateModel("Tech", "Automat oddechowy", "Średniej jakości i droższa wersja aparatu oddechowego do nurkowania", 2500, "~/images/Aut.Oddech/2.jpg", "a2"));
            automaty.Add(new ObjectTemplateModel("Mares", "Automat oddechowy", "Najdroższy aparat oddechowego do nurkowania", 4000, "~/images/Aut.Oddech/3.jpg", "a3"));

            this.boje = new List<ObjectTemplateModel>();
            boje.Add(new ObjectTemplateModel("Normalna", "Boja", "Boja zwyczajna", 50, "~/images/Boje/normalna.jpg", "bo1"));
            boje.Add(new ObjectTemplateModel("Awaryjna", "Boja", "Boja awaryjna", 75, "~/images/Boje/awaryjna.jpg", "bo2"));

            this.butle = new List<ObjectTemplateModel>();
            butle.Add(new ObjectTemplateModel("Szóstka", "Butla", "6l butla do nurkowania", 400, "~/images/Butle/6l.jpg", "bu1"));
            butle.Add(new ObjectTemplateModel("Dziesiątka", "Butla", "10l butla do nurkowania", 1000, "~/images/Butle/10l.jpg", "bu2"));
            butle.Add(new ObjectTemplateModel("Piętnastka", "Butla", "15l butla do nurkowania", 2300, "~/images/Butle/15l.jpg", "bu3"));
            butle.Add(new ObjectTemplateModel("Dwódziestka", "Butla", "20l butla do nurkowania", 4000, "~/images/Butle/20l.jpg", "bu4"));

            this.kamizelki = new List<ObjectTemplateModel>();
            kamizelki.Add(new ObjectTemplateModel("Prestige", "Jacket", "Najtańsza i najprostrza wersja kamizelki do nurkowania", 2200, "~/images/jacket/1.jpg", "j1"));
            kamizelki.Add(new ObjectTemplateModel("Beuchat", "Jacket", "Średniej jakości i droższa wersja kamizelki do nurkowania", 4200, "~/images/jacket/2.jpg", "j2"));
            kamizelki.Add(new ObjectTemplateModel("Cressi", "Jacket", "Najdroższa wersja kamizelki do nurkowania", 6200, "~/images/jacket/3.jpg", "j3"));

            this.skafandry = new List<ObjectTemplateModel>();
            skafandry.Add(new ObjectTemplateModel("Mokry", "Skafander", "Mokry skafander do nurkowania", 900, "~/images/Skafandry/mokry.jpg", "s1"));
            skafandry.Add(new ObjectTemplateModel("Półsuchy", "Skafander", "Półsuchy skafander do nurkowania", 1200, "~/images/Skafandry/polsuchy.jpg", "s2"));
            skafandry.Add(new ObjectTemplateModel("Suchy", "Skafander", "Suchy skafander do nurkowania", 2500, "~/images/Skafandry/suchy.jpg", "s3"));
        }

        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Automaty oddechowe
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Automaty()
        {
            return View(automaty);
        }

        /// <summary>
        /// POST request dla strony
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Automaty(IdModel id)
        {
            IdModel idModel = new IdModel
            {
                IdPrzycisku = id.IdPrzycisku
            };
            if (idModel.IdPrzycisku == "a1")
            {
                return View("Automaty_1ViewModel");
            }
            else if (idModel.IdPrzycisku == "a2")
            {
                return View("Automaty_2ViewModel");
            }
            else if (idModel.IdPrzycisku == "a3")
            {
                return View("Automaty_3ViewModel");
            }
            else
            {
                return Json(idModel.IdPrzycisku);
            }

        }

        /// <summary>
        /// Boje znacznikowe
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Boje()
        {
            return View(boje);
        }

        /// <summary>
        /// POST request dla strony
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Boje(IdModel id)
        {
            IdModel idModel = new IdModel
            {
                IdPrzycisku = id.IdPrzycisku
            };
            if (idModel.IdPrzycisku == "bo1")
            {
                return View("Boje_1ViewModel");
            }
            else if (idModel.IdPrzycisku == "bo2")
            {
                return View("Boje_2ViewModel");
            }
            else
            {
                return Json(idModel.IdPrzycisku);
            }

        }

        /// <summary>
        /// Butle z powietrzem
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Butle()
        {
            return View(butle);
        }

        /// <summary>
        /// POST request dla strony
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Butle(IdModel id)
        {
            IdModel idModel = new IdModel
            {
                IdPrzycisku = id.IdPrzycisku
            };
            if (idModel.IdPrzycisku == "bu1")
            {
                return View("Butle_1ViewModel");
            }
            else if (idModel.IdPrzycisku == "bu2")
            {
                return View("Butle_2ViewModel");
            }
            else if (idModel.IdPrzycisku == "bu3")
            {
                return View("Butle_3ViewModel");
            }
            else if (idModel.IdPrzycisku == "bu4")
            {
                return View("Butle_4ViewModel");
            }
            else
            {
                return Json(idModel.IdPrzycisku);
            }

        }

        /// <summary>
        /// Kamizelki do nurkowania
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Kamizelki()
        {
            return View(kamizelki);
        }

        /// <summary>
        /// POST request dla strony
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Kamizelki(IdModel id)
        {
            IdModel idModel = new IdModel
            {
                IdPrzycisku = id.IdPrzycisku
            };
            if (idModel.IdPrzycisku == "j1")
            {
                return View("Kamizelki_1ViewModel");
            }
            else if (idModel.IdPrzycisku == "j2")
            {
                return View("Kamizelki_2ViewModel");
            }
            else if (idModel.IdPrzycisku == "j3")
            {
                return View("Kamizelki_3ViewModel");
            }
            else
            {
                return Json(idModel.IdPrzycisku);
            }

        }

        /// <summary>
        /// Skafandry do nurkowania
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Skafandry()
        {
            return View(skafandry);
        }

        /// <summary>
        /// POST request dla strony
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Skafandry(IdModel id)
        {
            IdModel idModel = new IdModel
            {
                IdPrzycisku = id.IdPrzycisku
            };
            if (idModel.IdPrzycisku == "s1")
            {
                return View("Skafandry_1ViewModel");
            }
            else if (idModel.IdPrzycisku == "s2")
            {
                return View("Skafandry_2ViewModel");
            }
            else if (idModel.IdPrzycisku == "s3")
            {
                return View("Skafandry_3ViewModel");
            }
            else
            {
                return Json(idModel.IdPrzycisku);
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
