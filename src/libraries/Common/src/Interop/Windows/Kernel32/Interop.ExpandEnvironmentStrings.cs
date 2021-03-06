// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, EntryPoint = "ExpandEnvironmentStringsW", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        internal static extern uint ExpandEnvironmentStrings(string lpSrc, ref char lpDst, uint nSize);
    }
}
