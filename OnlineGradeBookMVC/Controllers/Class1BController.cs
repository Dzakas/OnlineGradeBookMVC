using Microsoft.AspNetCore.Mvc;
using OGB.Application.Interfaces;
using OGB.Application.ViewModels.Class1A.VmForEdit;
using OGB.Application.ViewModels.Class1B.VmForEdit;

namespace OnlineGradeBookMVC.Controllers
{
    public class Class1BController : Controller
    {
        private readonly IClass1BService _class1BService;
        public Class1BController(IClass1BService class1BService)
        {
            _class1BService = class1BService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _class1BService.GetAllStudentsForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1BService.GetAllStudentsForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsContactInformation()
        {
            var model = _class1BService.GetAllStudentsContanctInfoForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentsContactInformation(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1BService.GetAllStudentsContanctInfoForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult StudentsAvarages()
        {
            var model = _class1BService.GetAllAvarageGradesForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentsAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1BService.GetAllAvarageGradesForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult BiologyAvarages()
        {
            var model = _class1BService.GetAllBiologyForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult BiologyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1BService.GetAllBiologyForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult ChemistryAvarages()
        {
            var model = _class1BService.GetAllChemistryForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult ChemistryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1BService.GetAllChemistryForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult EnglishAvarages()
        {
            var model = _class1BService.GetAllEnglishForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult EnglishAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1BService.GetAllEnglishForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult GeographyAvarages()
        {
            var model = _class1BService.GetAllGeographyForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult GeographyAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1BService.GetAllGeographyForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult GermanAvarages()
        {
            var model = _class1BService.GetAllGermanForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult GermanAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1BService.GetAllGermanForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult HistoryAvarages()
        {
            var model = _class1BService.GetAllHistoryForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult HistoryAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1BService.GetAllHistoryForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult MathAvarages()
        {
            var model = _class1BService.GetAllMathForList(10, 1);
            return View(model);
        }
        [HttpPost]
        public IActionResult MathAvarages(int pageSize, int? pageNo)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            var model = _class1BService.GetAllMathForList(pageSize, pageNo.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult EditBiologyGrade(int id)
        {
            var biologyGrade = _class1BService.GetBiologyGradeForEdit(id);
            return View(biologyGrade);
        }
        [HttpPost]
        public IActionResult EditBiologyGrade(EditBiology1BVm model)
        {
            if (ModelState.IsValid)
            {
                _class1BService.UpdateBiologyGrade(model);
                return RedirectToAction("BiologyAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditChemistryGrade(int id)
        {
            var chemistryGrade = _class1BService.GetChemistryGradeForEdit(id);
            return View(chemistryGrade);
        }
        [HttpPost]
        public IActionResult EditChemistryGrade(EditChemistry1BVm model)
        {
            if (ModelState.IsValid)
            {
                _class1BService.UpdateChemistryGrade(model);
                return RedirectToAction("ChemistryAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditEnglishGrade(int id)
        {
            var englishGrade = _class1BService.GetEnglishGradeForEdit(id);
            return View(englishGrade);
        }
        [HttpPost]
        public IActionResult EditEnglishGrade(EditEnglish1BVm model)
        {
            if (ModelState.IsValid)
            {
                _class1BService.UpdateEnglishGrade(model);
                return RedirectToAction("EnglishAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditGeographyGrade(int id)
        {
            var geographyGrade = _class1BService.GetGeographyGradeForEdit(id);
            return View(geographyGrade);
        }
        [HttpPost]
        public IActionResult EditGeographyGrade(EditGeography1BVm model)
        {
            if (ModelState.IsValid)
            {
                _class1BService.UpdateGeographyGrade(model);
                return RedirectToAction("GeographyAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditGermanGrade(int id)
        {
            var germanGrade = _class1BService.GetGermanGradeForEdit(id);
            return View(germanGrade);
        }
        [HttpPost]
        public IActionResult EditGermanGrade(EditGerman1BVm model)
        {
            if (ModelState.IsValid)
            {
                _class1BService.UpdateGermanGrade(model);
                return RedirectToAction("GermanAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditHistoryGrade(int id)
        {
            var historyGrade = _class1BService.GetHistoryGradeForEdit(id);
            return View(historyGrade);
        }
        [HttpPost]
        public IActionResult EditHistoryGrade(EditHistory1BVm model)
        {
            if (ModelState.IsValid)
            {
                _class1BService.UpdateHistoryGrade(model);
                return RedirectToAction("HistoryAvarages");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditMathGrade(int id)
        {
            var mathGrade = _class1BService.GetMathGradeForEdit(id);
            return View(mathGrade);
        }
        [HttpPost]
        public IActionResult EditMathGrade(EditMath1BVm model)
        {
            if (ModelState.IsValid)
            {
                _class1BService.UpdateMathGrade(model);
                return RedirectToAction("MathAvarages");
            }
            return View(model);
        }   
    }
}
