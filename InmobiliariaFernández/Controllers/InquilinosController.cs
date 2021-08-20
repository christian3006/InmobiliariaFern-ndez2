﻿using InmobiliariaFernández.Models;
using Microsoft.AspNetCore.Mvc;

public class InquilinosController : Controller
{
    RepoInquilino repositorio;

    public InquilinosController()
    {
        repositorio = new RepoInquilino();
    }

    // GET: InquilinosController
    public ActionResult Index()
    {
        var list = repositorio.ObtenerTodos();
        return View(list);
    }

    // GET: InquilinosController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: InquilinosController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: InquilinosController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Inquilino i)
    {
        try
        {
            repositorio.Alta(i);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: InquilinosController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: InquilinosController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, Inquilino i)
    {
        try
        {
            repositorio.Modificar(i);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: InquilinosController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: InquilinosController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, Inquilino i)
    {
        try
        {
            repositorio.Baja(id);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
