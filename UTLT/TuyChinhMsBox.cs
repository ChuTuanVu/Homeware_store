#pragma warning disable 0618
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Permissions;

[assembly: SecurityPermission(SecurityAction.RequestMinimum, UnmanagedCode = true)]
namespace System.Windows.Forms
{
    public class TuyChinhMsBox
    {
        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        private delegate bool EnumChildProc(IntPtr hWnd, IntPtr lParam);
        private const int WH_CALLWNDPROCRET = 12;
        private const int WM_INITDIALOG = 0x0110;
        private const int MBOK = 1;
        private const int MBCancel = 2;
        private const int MBAbort = 3;
        private const int MBRetry = 4;
        private const int MBIgnore = 5;
        private const int MBYes = 6;
        private const int MBNo = 7;

		[DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

		[DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool EnumChildWindows(IntPtr hWndParent, EnumChildProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "GetClassNameW", CharSet = CharSet.Unicode)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern int GetDlgCtrlID(IntPtr hwndCtl);

        [DllImport("user32.dll")]
        private static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32.dll", EntryPoint = "SetWindowTextW", CharSet = CharSet.Unicode)]
        private static extern bool SetWindowText(IntPtr hWnd, string lpString);


		[StructLayout(LayoutKind.Sequential)]
		public struct CWPRETSTRUCT
		{
			public IntPtr lResult;
			public IntPtr lParam;
			public IntPtr wParam;
			public uint   message;
			public IntPtr hwnd;
		};

		private static readonly HookProc hookProc;
        private static readonly EnumChildProc enumChildProc;
        [ThreadStatic]
		private static IntPtr intPtr;
        [ThreadStatic]
        private static int nButton;
        public static string OK = "&OK";
        public static string Cancel = "&Cancel";
        public static string Abort = "&Abort";
        public static string Retry = "&Retry";
        public static string Ignore = "&Ignore";
        public static string Yes = "&Yes";
        public static string No = "&No";

		static TuyChinhMsBox()
		{
			hookProc = new HookProc(MessageBoxHookProc);
            enumChildProc = new EnumChildProc(MessageBoxEnumProc);
			intPtr = IntPtr.Zero;
		}

        public static void Bat()
        {
            if (intPtr == IntPtr.Zero)
            {
                Ky();
            }
        }

        private static void Ky()
		{
			if (intPtr != IntPtr.Zero)
				throw new NotSupportedException("One hook per thread allowed.");
			intPtr = SetWindowsHookEx(WH_CALLWNDPROCRET, hookProc, IntPtr.Zero, AppDomain.GetCurrentThreadId());
		}
		
		private static IntPtr MessageBoxHookProc(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (nCode < 0)
				return CallNextHookEx(intPtr, nCode, wParam, lParam);

			CWPRETSTRUCT msg = (CWPRETSTRUCT)Marshal.PtrToStructure(lParam, typeof(CWPRETSTRUCT));
			IntPtr hook = intPtr;

            if (msg.message == WM_INITDIALOG)
            {
                StringBuilder className = new StringBuilder(10);
                GetClassName(msg.hwnd, className, className.Capacity);
                if (className.ToString() == "#32770")
                {
                    nButton = 0;
                    EnumChildWindows(msg.hwnd, enumChildProc, IntPtr.Zero);
                    if (nButton == 1)
                    {
                        IntPtr hButton = GetDlgItem(msg.hwnd, MBCancel);
                        if (hButton != IntPtr.Zero)
                            SetWindowText(hButton, OK);
                    }
                }
            }

			return CallNextHookEx(hook, nCode, wParam, lParam);
		}

        private static bool MessageBoxEnumProc(IntPtr hWnd, IntPtr lParam)
        {
            StringBuilder className = new StringBuilder(10);
            GetClassName(hWnd, className, className.Capacity);
            if (className.ToString() == "Button")
            {
                int ctlId = GetDlgCtrlID(hWnd);
                switch (ctlId)
                {
                    case MBOK:
                        SetWindowText(hWnd, OK);
                        break;
                    case MBCancel:
                        SetWindowText(hWnd, Cancel);
                        break;
                    case MBAbort:
                        SetWindowText(hWnd, Abort);
                        break;
                    case MBRetry:
                        SetWindowText(hWnd, Retry);
                        break;
                    case MBIgnore:
                        SetWindowText(hWnd, Ignore);
                        break;
                    case MBYes:
                        SetWindowText(hWnd, Yes);
                        break;
                    case MBNo:
                        SetWindowText(hWnd, No);
                        break;

                }
                nButton++;
            }
            return true;
        }
	}
}