using Data.Contract;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class ImagesController : CrudController<ImageDto, ImageSelectDto, Image>
    {
        public ImagesController(IRepository<Image> repository)
            : base(repository)
        {
        }
    }
}
