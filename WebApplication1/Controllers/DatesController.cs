using Data.Contract;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class DatesController : CrudController<DateDto, DateSelectDto, Date>
    {
        public DatesController(IRepository<Date> repository)
            : base(repository)
        {
        }
    }
}
