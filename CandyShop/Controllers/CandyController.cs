using CandyShop.Models;
using CandyShop.Repository;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClotheShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository ;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Candy> candies;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                candies = _candyRepository.GetAllCandy.OrderBy(c => c.CandyId);
                currentCategory = "All Candy";
            }
            else
            {
                candies = _candyRepository.GetAllCandy.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CandyListViewModel
            {
                Candies = candies,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var candy = _candyRepository.GetCandyById(id);
            if (candy == null)
                return NotFound();
            return View(candy);
        }
    }
}
