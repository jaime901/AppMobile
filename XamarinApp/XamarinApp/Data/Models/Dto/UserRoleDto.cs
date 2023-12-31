﻿using System;
using System.Collections.Generic;
using System.Text;
using XamarinApp.Enumerations;

namespace XamarinApp.Data.Models.Dto
{
    public class UserRoleDto
    {
        public long RoleId { get; set; }
        public string Name { get; set; }
        public RoleType Type { get; set; }
    }

}
