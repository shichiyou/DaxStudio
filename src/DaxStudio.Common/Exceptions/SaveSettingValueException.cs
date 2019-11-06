﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaxStudio.Common.Exceptions
{

    public class SaveSettingValueException:Exception
    {
        public SaveSettingValueException():base() { }
        public SaveSettingValueException(string message, Exception innerException) : base(message, innerException) { }

        public SaveSettingValueException(string message) : base(message)
        {
        }

    }
}