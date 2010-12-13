﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;

namespace Recorder.Core.Utils
{
    [ComVisible(true), ComImport()]
    [Guid("04C9C413-C6BF-4d77-9603-6511DBEEFE35")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IViewObject
    {
        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Draw([MarshalAs(UnmanagedType.U4)] UInt32 dwDrawAspect,
        int lindex,
        IntPtr pvAspect,
        [In] IntPtr ptd,
        IntPtr hdcTargetDev,
        IntPtr hdcDraw,
        [MarshalAs(UnmanagedType.Struct)] ref Rectangle lprcBounds,
        [MarshalAs(UnmanagedType.Struct)] ref Rectangle lprcWBounds,
        IntPtr pfnContinue,
        [MarshalAs(UnmanagedType.U4)] UInt32 dwContinue);
        [PreserveSig]
        int GetColorSet([In, MarshalAs(UnmanagedType.U4)] int dwDrawAspect,
           int lindex, IntPtr pvAspect, [In] IntPtr ptd,
            IntPtr hicTargetDev, [Out] IntPtr ppColorSet);
        [PreserveSig]
        int Freeze([In, MarshalAs(UnmanagedType.U4)] int dwDrawAspect,
                        int lindex, IntPtr pvAspect, [Out] IntPtr pdwFreeze);
        [PreserveSig]
        int Unfreeze([In, MarshalAs(UnmanagedType.U4)] int dwFreeze);
        void SetAdvise([In, MarshalAs(UnmanagedType.U4)] int aspects,
          [In, MarshalAs(UnmanagedType.U4)] int advf,
          [In, MarshalAs(UnmanagedType.Interface)] IAdviseSink pAdvSink);
        void GetAdvise([In, Out, MarshalAs(UnmanagedType.LPArray)] int[] paspects,
          [In, Out, MarshalAs(UnmanagedType.LPArray)] int[] advf,
          [In, Out, MarshalAs(UnmanagedType.LPArray)] IAdviseSink[] pAdvSink);

    }
}
