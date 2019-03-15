﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAPI.Model;

namespace CarServiceAPI.Repository.Read
{
    public interface IReadAutoRepository : IReadRepository<Auto>
    {
        Auto GetBySasiuId(int sasiuId);
    }
}
