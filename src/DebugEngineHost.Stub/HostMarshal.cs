﻿using Microsoft.VisualStudio.Debugger.Interop;
using System;

namespace Microsoft.DebugEngineHost
{
    public static class HostMarshal
    {
        public static IntPtr RegisterCodeContext(IDebugCodeContext2 codeContext)
        {
            throw new NotImplementedException();
        }

        public static IDebugDocumentPosition2 GetDocumentPositionForIntPtr(IntPtr documentPositionId)
        {
            throw new NotImplementedException();
        }

        public static IDebugEventCallback2 GetThreadSafeEventCallback(IDebugEventCallback2 ad7Callback)
        {
            throw new NotImplementedException();
        }
    }
}
