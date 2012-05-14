﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Kendo.Mvc.Examples.Models
{
    public static class Config
    {
        public static readonly string NavigationData;

        static Config()
        {
            NavigationData = ConfigurationManager.AppSettings["NavigationData"];
        }
    }
}