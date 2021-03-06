
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace System.Runtime
{
    public static partial class RuntimeImports
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        internal static extern unsafe void _ecvt_s(byte* buffer, int sizeInBytes, double value, int count, int* dec, int* sign);
    }
}
