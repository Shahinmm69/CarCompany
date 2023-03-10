using Data.Contract;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class ModelsController : CrudController<CarModelDto, ModelSelectDto, CarModel>
    {
        public ModelsController(IRepository<CarModel> repository)
            : base(repository)
        {
        }
    }
}
