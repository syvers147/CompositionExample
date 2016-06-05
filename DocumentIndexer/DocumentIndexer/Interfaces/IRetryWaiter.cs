﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentIndexer.Interfaces
{
    public interface IRetryWaiter
    {
        void WaitForRetry(int retryNumber);
    }
}
