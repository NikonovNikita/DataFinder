﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFinder.BLL;

internal class BusinessRuleException : Exception
{
    public BusinessRuleException(string message) : base(message) { }
}
