﻿using ClassifiedAds.Domain.Entities;
using System;

namespace ClassifiedAds.Services.Storage.Entities
{
    public class AuditLogEntry : AggregateRoot<Guid>
    {
        public Guid UserId { get; set; }

        public string Action { get; set; }

        public string ObjectId { get; set; }

        public string Log { get; set; }
    }
}
