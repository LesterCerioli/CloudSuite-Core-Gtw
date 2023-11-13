﻿using CloudSuite.Modules.Application.Core;
using FluentValidation.Results;

namespace CloudSuite.Modules.Application.Handlers.Company.Responses
{
    public class CheckCompanyExistsByRegisterNameResponse : Response
    {
        public Guid RequestId { get; private set; }
        public bool Exists { get; set; }

        public CheckCompanyExistsByRegisterNameResponse(Guid requestId, bool exists, ValidationResult result)
        {
            RequestId = requestId;
            Exists = exists;
            foreach (var item in result.Errors)
            {
                this.AddError(item.ErrorMessage);
            }
        }

        public CheckCompanyExistsByRegisterNameResponse(Guid requestId, string falseValidation)
        {
            RequestId = requestId;
            Exists = false;
            this.AddError(falseValidation);
        }
    }
}
