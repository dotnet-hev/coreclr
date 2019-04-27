// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class Advapi32
    {
        [DllImport(Libraries.Advapi32, ExactSpelling = true)]
        internal static unsafe extern int EventSetInformation(
            long registrationHandle,
            EVENT_INFO_CLASS informationClass,
            void* eventInformation,
            int informationLength);
    }
}