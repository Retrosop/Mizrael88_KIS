﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;
using System.Collections;

namespace RunGroopWebApp.Controllers;

public class RaceController : Controller
{
    private readonly IRaceRepository _raceRepository;

    public RaceController(IRaceRepository raceRepository)
    {
        _raceRepository = raceRepository;
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
}