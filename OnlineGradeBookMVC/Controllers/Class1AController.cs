using Microsoft.AspNetCore.Mvc;
using OGB.Application.Interfaces;
using OGB.Application.ViewModels;
using OGB.Application.ViewModels.Class1A.VmForEdit;

namespace OnlineGradeBookMVC.Controllers
{
    public class Class1AController : Controller
    {
        private readonly IClass1AService _class1AService;
        public Class1AController(IClass1AService class1AService)
        {
            _class1AService = class1AService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _class1AService.GetAllStudentsForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult StudentsContactInformation()
        {
            var model = _class1AService.GetAllStudentsContanctInfoForList();
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsAvarages()
        {
            var model = _class1AService.GetAllAvarageGradesForList();
            return View(model);
        }
        [HttpGet]
        public IActionResult BiologyAvarages()
        {
            var model = _class1AService.GetAllBiologyForList();
            return View(model);
        }
        [HttpGet]
        public IActionResult ChemistryAvarages()
        {
            var model = _class1AService.GetAllChemistryForList();
            return View(model);
        }
        [HttpGet]
        public IActionResult EnglishAvarages()
        {
            var model = _class1AService.GetAllEnglishForList();
            return View(model);
        }
        [HttpGet]
        public IActionResult GeographyAvarages()
        {
            var model = _class1AService.GetAllGeographyForList();
            return View(model);
        }
        [HttpGet]
        public IActionResult GermanAvarages()
        {
            var model = _class1AService.GetAllGermanForList();
            return View(model);
        }
        [HttpGet]
        public IActionResult HistoryAvarages()
        {
            var model = _class1AService.GetAllHistoryForList();
            return View(model);
        }
        [HttpGet]
        public IActionResult MathAvarages()
        {
            var model = _class1AService.GetAllMathForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult EditBiologyGrade(int id)
        {
            var biologyGrade = _class1AService.GetBiologyGradeForEdit(id);
            return View(biologyGrade);
        }
        [HttpPost]
        public IActionResult EditBiologyGrade(EditBiology1AVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateBiologyGrade(model);
                return RedirectToAction("BiologyAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditChemistryGrade(int id)
        {
            var chemistryGrade = _class1AService.GetChemistryGradeForEdit(id);
            return View(chemistryGrade);
        }
        [HttpPost]
        public IActionResult EditChemistryGrade(EditChemistry1AVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateChemistryGrade(model);
                return RedirectToAction("ChemistryAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditEnglishGrade(int id)
        {
            var englishGrade = _class1AService.GetEnglishGradeForEdit(id);
            return View(englishGrade);
        }
        [HttpPost]
        public IActionResult EditEnglishGrade(EditEnglish1AVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateEnglishGrade(model);
                return RedirectToAction("EnglishAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditGeographyGrade(int id)
        {
            var geographyGrade = _class1AService.GetGeographyGradeForEdit(id);
            return View(geographyGrade);
        }
        [HttpPost]
        public IActionResult EditGeographyGrade(EditGeography1AVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateGeographyGrade(model);
                return RedirectToAction("GeographyAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditGermanGrade(int id)
        {
            var germanGrade = _class1AService.GetGermanGradeForEdit(id);
            return View(germanGrade);
        }
        [HttpPost]
        public IActionResult EditGermanGrade(EditGerman1AVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateGermanGrade(model);
                return RedirectToAction("GermanAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditHistoryGrade(int id)
        {
            var historyGrade = _class1AService.GetHistoryGradeForEdit(id);
            return View(historyGrade);
        }
        [HttpPost]
        public IActionResult EditHistoryGrade(EditHistory1AVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateHistoryGrade(model);
                return RedirectToAction("HistoryAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditMathGrade(int id)
        {
            var mathGrade = _class1AService.GetMathGradeForEdit(id);
            return View(mathGrade);
        }
        [HttpPost]
        public IActionResult EditMathGrade(EditMath1AVm model)
        {
            if (ModelState.IsValid)
            {
                _class1AService.UpdateMathGrade(model);
                return RedirectToAction("MathAvarages");
            }
            return View(model);
        }
    }
}
