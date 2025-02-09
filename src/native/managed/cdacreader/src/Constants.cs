// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Diagnostics.DataContractReader;

internal static class Constants
{
    internal static class Globals
    {
        // See src/coreclr/debug/runtimeinfo/datadescriptor.h
        internal const string AppDomain = nameof(AppDomain);
        internal const string ThreadStore = nameof(ThreadStore);
        internal const string FinalizerThread = nameof(FinalizerThread);
        internal const string GCThread = nameof(GCThread);

        internal const string FeatureEHFunclets = nameof(FeatureEHFunclets);
        internal const string SOSBreakingChangeVersion = nameof(SOSBreakingChangeVersion);

        internal const string FreeObjectMethodTable = nameof(FreeObjectMethodTable);

        internal const string MiniMetaDataBuffAddress = nameof(MiniMetaDataBuffAddress);
        internal const string MiniMetaDataBuffMaxSize = nameof(MiniMetaDataBuffMaxSize);
    }
}
