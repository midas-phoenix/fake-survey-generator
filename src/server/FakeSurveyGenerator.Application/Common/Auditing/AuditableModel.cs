﻿using System;

namespace FakeSurveyGenerator.Application.Common.Auditing
{
    public class AuditableModel
    {
        public string CreatedBy { get; init; }

        public DateTimeOffset CreatedOn { get; init; }

        public string ModifiedBy { get; init; }

        public DateTimeOffset? ModifiedOn { get; init; }
    }
}
