﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;
using RunGroopWebApp.Repository;
using RunGroopWebApp.Services;
using RunGroopWebApp.ViewModels;
using System.Collections;

namespace RunGroopWebApp.Controllers;

public class RaceController : Controller
{
    private readonly IRaceRepository _raceRepository;
    private readonly IPhotoService _photoService;

    public RaceController(IRaceRepository raceRepository, IPhotoService photoService)
    {
        _raceRepository = raceRepository;
        _photoService = photoService;
    }
    public async Task<IActionResult> Index()
    {
        IEnumerable<Race> races = await _raceRepository.GetAll();
        return View(races);
    }
    public async Task<IActionResult> Detail(int id)
    {
        Race race = await _raceRepository.GetByIdAsync(id);
        return View(race);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateRaceViewModel raceVM)
    {
        if (ModelState.IsValid)
        {
            var result = await _photoService.AddPhotoAsync(raceVM.Image);

            var race = new Race
            {
                Title = raceVM.Title,
                Description = raceVM.Description,
                Image = result.Url.ToString(),
                Address = new Address
                {
                    Street = raceVM.Address.Street,
                    City = raceVM.Address.City,
                    State = raceVM.Address.State
                }
            };
            _raceRepository.Add(race);
            return RedirectToAction("Index");
        }
        else
        {
            ModelState.AddModelError("", "Загрузка фото не удалась");
        }
        return View(raceVM);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var race = await _raceRepository.GetByIdAsync(id);
        if (race == null) return View("Error");
        var raceVM = new EditRaceViewModel
        {
            Title = race.Title,
            Description = race.Description,
            AddressId = race.AddressId,
            Address = race.Address,
            URL = race.Image,
            RaceCategory = race.RaceCategory
        };
        return View(raceVM);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, EditRaceViewModel raceVM)
    {
        if (!ModelState.IsValid)
        {
            ModelState.AddModelError("", "Редактирование не удалось");
            return View("Edit", raceVM);
        }

        var userRace = await _raceRepository.GetByIdAsyncNoTracking(id);

        if (userRace != null)
        {
            try
            {
                await _photoService.DeletePhotoAsync(userRace.Image);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Не удалось удалить фотографию");
                return View(raceVM);
            }
            var photoResult = await _photoService.AddPhotoAsync(raceVM.Image);

            var race = new Race
            {
                Id = id,
                Title = raceVM.Title,
                Description = raceVM.Description,
                Image = photoResult.Url.ToString(),
                AddressId = raceVM.AddressId,
                Address = raceVM.Address,
            };

            _raceRepository.Update(race);

            return RedirectToAction("Index");
        }
        else
        {
            return View(raceVM);
        }
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var clubDetails = await _raceRepository.GetByIdAsync(id);
        if (clubDetails == null) return View("Error");
        return View(clubDetails);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteClub(int id)
    {
        var raceDetails = await _raceRepository.GetByIdAsync(id);

        if (raceDetails == null)
        {
            return View("Error");
        }

        if (!string.IsNullOrEmpty(raceDetails.Image))
        {
            _ = _photoService.DeletePhotoAsync(raceDetails.Image);
        }

        _raceRepository.Delete(raceDetails);
        return RedirectToAction("Index");
    }
}