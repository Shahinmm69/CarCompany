using Data.Contract;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class ModelsController : CrudController<ModelDto, ModelSelectDto, Model>
    {
        public ModelsController(IRepository<Model> repository)
            : base(repository)
        {
        }
    }
}
