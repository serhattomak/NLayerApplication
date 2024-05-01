using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Services;

namespace NLayer.Web.Controllers;

public class ProductsController : Controller
{
    private readonly IProductService _services;
    private readonly IMapper _mapper;

    public ProductsController(IProductService services, IMapper mapper)
    {
        _services = services;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _services.GetProductsWithCategory());
    }

}