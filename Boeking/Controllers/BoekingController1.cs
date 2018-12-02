using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boeking.Models;
using Microsoft.AspNetCore.Mvc;

namespace Boeking.Controllers
{
    public class BoekingController1 : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        

        /*
      Maak een formulier waarmee je een nieuwe hotelkamer kunt boeken(= Create).
      Met behulp van het PRG-pattern wordt een gebruiker doorgestuurd naar een pagina,
          waarin een bedanktboodschap voor de boeking wordt getoond(waaronder natuurlijk de relevente gegevens voor de boeking worden getoond).
      De boeking wordt(nog) niet opgeslagen in een database.
      */ 

        [HttpPost]
        public IActionResult boeken(String first, String last)
        {
            List<HotelB> list = new List<HotelB>();

            HotelB hb = new HotelB
            {
                naam = first,
                achternaam = last
            };
            list.Add(hb);
            return View();
        }

    }
}
