Imports System.Runtime.InteropServices
Imports System.Diagnostics

Module determine64bitOS

    'API Definitions

    ''' <summary>
    ''' Determines if a process is running on a 64 bit Operating System but in 32 bit emulation mode (WOW64)
    ''' </summary>
    ''' <param name="hProcess">A handle to the process to check</param>
    ''' <param name="Wow64Process">Output parameter. A boolean that will be set to True if the process is running in WOW64 mode</param>
    <System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint:="IsWow64Process")> _
    Public Function IsWow64Process(<System.Runtime.InteropServices.InAttribute()> ByVal hProcess As System.IntPtr, <System.Runtime.InteropServices.OutAttribute()> ByRef Wow64Process As Boolean) As <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)> Boolean
    End Function

    ''' <summary>
    ''' Determines if a method exists in the specified DLL
    ''' </summary>
    ''' <param name="moduleName">The DLL to look for the method in</param>
    ''' <param name="methodName">The method to look for</param>
    Public Function DoesWin32MethodExist(ByVal moduleName As String, ByVal methodName As String) As Boolean
        Dim moduleHandle As IntPtr = GetModuleHandle(moduleName)
        If (moduleHandle = IntPtr.Zero) Then
            Return False
        End If
        Return (GetProcAddress(moduleHandle, methodName) <> IntPtr.Zero)
    End Function

    ''' <summary>
    ''' Gets a handle to a specified DLL
    ''' </summary>
    ''' <param name="moduleName">The module to return a handle for</param>
    <Runtime.ConstrainedExecution.ReliabilityContract(Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, Runtime.ConstrainedExecution.Cer.MayFail), DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Function GetModuleHandle(ByVal moduleName As String) As IntPtr
    End Function

    ''' <summary>
    ''' Retrieves the address of an exported function or variable from the specified dynamic-link library (DLL)
    ''' </summary>
    ''' <param name="hModule">A handle to the DLL to look for the method in</param>
    ''' <param name="methodName">The method to look for</param>
    <DllImport("kernel32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Function GetProcAddress(ByVal hModule As IntPtr, ByVal methodName As String) As IntPtr
    End Function


    Public Function OSVersion() As String
        Return Environment.OSVersion.ToString
    End Function



    ''' <summary>
    ''' Determines whether or not the operating system is 64 bit
    ''' </summary>
    Public ReadOnly Property Is64BitOperatingSystem() As Boolean
        Get
            If IntPtr.Size = 8 Then
                Return True
            Else
                Dim Is64 As Boolean = False
                If DoesWin32MethodExist("kernel32.dll", "IsWow64Process") Then
                    IsWow64Process(Process.GetCurrentProcess.Handle, Is64)
                End If
                Return Is64
            End If
        End Get
    End Property

End Module
