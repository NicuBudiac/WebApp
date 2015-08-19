﻿using System;
using System.Web.Mvc;
using MVCForum.Domain.Interfaces.Services;

namespace MVCForum.Domain.DomainModel.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DescriptionAttribute : Attribute
    {
        private readonly ILocalizationService _localizationService;
        public DescriptionAttribute()
        {
            _localizationService = DependencyResolver.Current.GetService<ILocalizationService>();
        }

        public string Description { get; set; }

        public DescriptionAttribute(string desc)
        {
            Description = _localizationService.GetResourceString(desc.Trim());
        }
    }
}
