using Data.Contract;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CarsController : CrudController<CarDto, CarSelectDto, Car>
    {
        public CarsController(IRepository<Car> repository)
            : base(repository)
        {
        }
    }
}
