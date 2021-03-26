using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_1_25_03_21.Repositories
{
    interface IReadAllFromDB<T>
    {
        List<T> ReadAll();
    }
}
