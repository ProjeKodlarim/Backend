﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Entities.Dtos
{
    public class UserForLoginDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
