using Microsoft.AspNetCore.Mvc;
using OGB.Application.Interfaces;
using OGB.Application.ViewModels.Class1B.VmForEdit;
using OGB.Application.ViewModels.Class1C.VmForEdit;

namespace OnlineGradeBookMVC.Controllers
{
    public class Class1CController : Controller
    {
        private readonly IClass1CService _class1CService;
        public Class1CController(IClass1CService class1CService)
        {
            _class1CService = class1CService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _class1CService.GetAllStudentsForList(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsContactInformation()
        {
            var model = _class1CService.GetAllStudentsContanctInfoForList(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsAvarages()
        {
            var model = _class1CService.GetAllAvarageGradesForList(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult BiologyAvarages()
        {
            var model = _class1CService.GetAllBiologyForList(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult ChemistryAvarages()
        {
            var model = _class1CService.GetAllChemistryForList(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult EnglishAvarages()
        {
            var model = _class1CService.GetAllEnglishForList(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult GeographyAvarages()
        {
            var model = _class1CService.GetAllGeographyForList(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult GermanAvarages()
        {
            var model = _class1CService.GetAllGermanForList(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult HistoryAvarages()
        {
            var model = _class1CService.GetAllHistoryForList(10, 1);
            return View(model);
        }
        [HttpGet]
        public IActionResult MathAvarages()
        {
            var model = _class1CService.GetAllMathForList(10, 1);
            return View(model);
        }

        [HttpGet]
        public IActionResult EditBiologyGrade(int id)
        {
            var biologyGrade = _class1CService.GetBiologyGradeForEdit(id);
            return View(biologyGrade);
        }
        [HttpPost]
        public IActionResult EditBiologyGrade(EditBiology1CVm model)
        {
            if (ModelState.IsValid)
            {
                _class1CService.UpdateBiologyGrade(model);
                return RedirectToAction("BiologyAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditChemistryGrade(int id)
        {
            var chemistryGrade = _class1CService.GetChemistryGradeForEdit(id);
            return View(chemistryGrade);
        }
        [HttpPost]
        public IActionResult EditChemistryGrade(EditChemistry1CVm model)
        {
            if (ModelState.IsValid)
            {
                _class1CService.UpdateChemistryGrade(model);
                return RedirectToAction("ChemistryAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditEnglishGrade(int id)
        {
            var englishGrade = _class1CService.GetEnglishGradeForEdit(id);
            return View(englishGrade);
        }
        [HttpPost]
        public IActionResult EditEnglishGrade(EditEnglish1CVm model)
        {
            if (ModelState.IsValid)
            {
                _class1CService.UpdateEnglishGrade(model);
                return RedirectToAction("EnglishAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditGeographyGrade(int id)
        {
            var geographyGrade = _class1CService.GetGeographyGradeForEdit(id);
            return View(geographyGrade);
        }
        [HttpPost]
        public IActionResult EditGeographyGrade(EditGeography1CVm model)
        {
            if (ModelState.IsValid)
            {
                _class1CService.UpdateGeographyGrade(model);
                return RedirectToAction("GeographyAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditGermanGrade(int id)
        {
            var germanGrade = _class1CService.GetGermanGradeForEdit(id);
            return View(germanGrade);
        }
        [HttpPost]
        public IActionResult EditGermanGrade(EditGerman1CVm model)
        {
            if (ModelState.IsValid)
            {
                _class1CService.UpdateGermanGrade(model);
                return RedirectToAction("GermanAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditHistoryGrade(int id)
        {
            var historyGrade = _class1CService.GetHistoryGradeForEdit(id);
            return View(historyGrade);
        }
        [HttpPost]
        public IActionResult EditHistoryGrade(EditHistory1CVm model)
        {
            if (ModelState.IsValid)
            {
                _class1CService.UpdateHistoryGrade(model);
                return RedirectToAction("HistoryAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditMathGrade(int id)
        {
            var mathGrade = _class1CService.GetMathGradeForEdit(id);
            return View(mathGrade);
        }
        [HttpPost]
        public IActionResult EditMathGrade(EditMath1CVm model)
        {
            if (ModelState.IsValid)
            {
                _class1CService.UpdateMathGrade(model);
                return RedirectToAction("MathAvarages");
            }
            return View(model);
        }
    }
}
