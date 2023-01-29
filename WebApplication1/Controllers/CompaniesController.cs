using Data.Contract;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CompaniesController : CrudController<CompanyDto, CompanySelectDto, Company>
    {
        public CompaniesController(IRepository<Company> repository)
            : base(repository)
        {
        }
    }
}
