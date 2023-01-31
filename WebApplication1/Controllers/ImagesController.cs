using Data.Contract;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class ImagesController : CrudController<CarImagesGalleryDto, ImageSelectDto, CarImagesGallery>
    {
        public ImagesController(IRepository<CarImagesGallery> repository)
            : base(repository)
        {
        }
    }
}
