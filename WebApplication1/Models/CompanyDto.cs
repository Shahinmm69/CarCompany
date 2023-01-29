﻿using AutoMapper;
using Entities;
using System;
using WebFramework.Api;

namespace MyApi
{
    public class CompanyDto : BaseDto<CompanyDto, Company, Guid>
    {
        public string CompanyName { get; set; }
    }

    public class CompanySelectDto : BaseDto<CompanySelectDto, Company, Guid>
    {
        public string CompanyName { get; set; }
    }
}
