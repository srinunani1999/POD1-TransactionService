﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TransactionService.ClientAddress
{
    public class Clients
    {
        public HttpClient AccountDetails()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://20.62.143.11/");
            //https: //localhost:44338
            return client;
        }

        public HttpClient RuleApi()
        {
            var client = new HttpClient();
            //https: //localhost:44384
            client.BaseAddress = new Uri("http://40.88.251.135/");
            return client;
        }
    }
}

