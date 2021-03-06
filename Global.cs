﻿using ITSIContaDesktopClient.PersistenceConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ITSIContaDesktopClient
{
    class Global
    {
        public const string DB_NAME = "ITSIconta";
        public const string APIURL = "http://localhost:8080/";
        public static string APIToken = "";
        public static bool isConnected = false;
        public static HttpClient APIClient;
        public static LocalContext Db;
    }
}
