﻿using UtilityInterface.NonGeneric.Data;

namespace UtilityInterface.Generic.Database
{
    public interface IChild<T> : IChild where T : IId
    {
        T Parent { get;  }
    }

}