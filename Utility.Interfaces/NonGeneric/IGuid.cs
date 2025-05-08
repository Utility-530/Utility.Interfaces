﻿using System;

namespace Utility.Interfaces.NonGeneric
{
    public interface IGuid
    {
        Guid Guid { get; set; }
    }

    public interface IGetGuid
    {
        Guid Guid { get; }
    }

    public interface ISetGuid
    {
        Guid Guid { set; }
    }
}