﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces
{
    public interface IUserDto : IBaseUserDto
    {
        string UserName { get; set; }
        string Email { get; set; }
        bool EmailConfirmed { get; set; }
        string PhoneNumber { get; set; }
        bool PhoneNumberConfirmed { get; set; }
        bool LockoutEnabled { get; set; }
        bool TwoFactorEnabled { get; set; }
        string AccessFailedCount { get; set; }
        DateTimeOffset? LockoutEnd { get; set; }

        string SIO_Apodo { get; set; }

        string SIO_uid { get; set; }

        string given_name { get; set; }
    }
}
