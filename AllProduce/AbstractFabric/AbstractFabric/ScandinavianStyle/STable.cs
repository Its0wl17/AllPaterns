﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    public class STable : ITable
    {
        public string TableStyle()
        {
            return $"Столик в стиле Scandinavian";
        }
    }
}
