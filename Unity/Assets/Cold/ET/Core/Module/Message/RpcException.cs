﻿using System;

#if NOT_UNITY
namespace ET
#else 
namespace ETCold
#endif
{
    /// <summary>
    /// RPC异常,带ErrorCode
    /// </summary>
    [Serializable]
    public class RpcException: Exception
    {
        public int Error
        {
            get;
            private set;
        }

        public RpcException(int error, string message): base($"Error: {error} Message: {message}")
        {
            this.Error = error;
        }

        public RpcException(int error, string message, Exception e): base($"Error: {error} Message: {message}", e)
        {
            this.Error = error;
        }
    }
}