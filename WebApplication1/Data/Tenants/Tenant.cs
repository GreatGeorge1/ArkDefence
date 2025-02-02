﻿using Finbuckle.MultiTenant.Stores;
using System;

namespace WebApplication1.Data
{
    public class Tenant : IEFCoreStoreTenantInfo
    {
        public string Id { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ConnectionString { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}