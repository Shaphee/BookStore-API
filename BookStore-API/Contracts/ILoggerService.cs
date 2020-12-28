using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Contracts
{
    //Here we have changed class to interface beacsue this is ILoggerService(I)
    public interface ILoggerService
    {
        //create some some functions

        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);

    }
}