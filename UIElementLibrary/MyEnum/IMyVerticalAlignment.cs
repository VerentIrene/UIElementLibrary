﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UIElementLibrary.MyEnum
{
    public interface IMyVerticalAlignment
    {
        VerticalAlignment setTop();

        VerticalAlignment setCenter();

        VerticalAlignment setBottom();

        VerticalAlignment setStretch();

    }
}
