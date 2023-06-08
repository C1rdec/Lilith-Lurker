using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace LilithLurker;

public static class ProcessExtensions
{
    public static string GetMainModuleFileName(this Process process, int buffer = 1024)
    {
        var fileNameBuilder = new StringBuilder(buffer);
        uint bufferLength = (uint)fileNameBuilder.Capacity + 1;
        return Native.QueryFullProcessImageName(process.Handle, 0, fileNameBuilder, ref bufferLength) ?
            fileNameBuilder.ToString() :
            null;
    }

    public static IntPtr GetWindowHandle(this Process process)
    {
        process.Refresh();
        Process newProcess;

        try
        {
            do
            {
                newProcess = Process.GetProcessesByName(process.ProcessName).FirstOrDefault();
                Thread.Sleep(200);
                if (process == null)
                {
                    throw new InvalidOperationException();
                }
            }
            while (newProcess.MainWindowHandle == IntPtr.Zero);
        }
        catch
        {
            return process.GetWindowHandle();
        }

        return newProcess.MainWindowHandle;
    }
}
