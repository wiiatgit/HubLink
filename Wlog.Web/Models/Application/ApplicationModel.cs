﻿//******************************************************************************
// <copyright file="license.md" company="Wlog project  (https://github.com/arduosoft/wlog)">
// Copyright (c) 2016 Wlog project  (https://github.com/arduosoft/wlog)
// Wlog project is released under LGPL terms, see license.md file.
// </copyright>
// <author>Daniele Fontani, Emanuele Bucaelli</author>
// <autogenerated>true</autogenerated>
//******************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Wlog.Web.Filters;
using Wlog.Web.Resources;

namespace Wlog.Web.Models
{
    /// <summary>
    /// Model used to save an application
    /// </summary>
    public class ApplicationModel
    {
        [Required]
        [Display(ResourceType = typeof(Labels), Name = "IdApplication")]
        public virtual Guid IdApplication { get; set; }

        [Required]
        [Display(ResourceType = typeof(Labels), Name = "ApplicationName")]
        public virtual string ApplicationName { get; set; }

        [Required]
        [Display(ResourceType = typeof(Labels), Name = "Active")]
        public virtual bool IsActive { get; set; }

        [Required]
        [Display(ResourceType = typeof(Labels), Name = "StartDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public virtual DateTime StartDate { get; set; }

        [Display(ResourceType = typeof(Labels), Name = "EndDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public virtual System.Nullable<DateTime> EndDate { get; set; }

        [Required]
        [Display(ResourceType = typeof(Labels), Name = "PublicKey")]
        public virtual Guid PublicKey { get; set; }

        public ApplicationModel()
        {
            StartDate = DateTime.UtcNow;
        }
    }
}