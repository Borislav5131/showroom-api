﻿using Showroom.Core.Interfaces;
using Showroom.Core.ViewModels;
using Showroom.Core.ViewModels.Parts;

namespace Showroom.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PartsController : Controller
    {
        private readonly IPartService _partService;

        public PartsController(IPartService partService)
        {
            _partService = partService;
        }

        [HttpGet]
        public ActionResult All()
        {
            var parts = _partService.GetAllParts();

            return View(parts);
        }

        [HttpGet]
        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(CreatePartFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var (added, error) = _partService.Create(model);

            if (!added)
            {
                ModelState.AddModelError("", error);
                return View();
            }

            return Redirect("/Parts/All");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            var deleted = _partService.Delete(id);

            if (!deleted)
            {
                return View("Error", new ErrorViewModel() { ErrorMessage = "Part can't be deleted!" });
            }

            return Redirect("/Parts/All");
        }
    }
}
