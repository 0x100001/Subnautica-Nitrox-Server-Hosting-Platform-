namespace _x101.HWID_System
{
    public static class HW_UID_ENGINE
    {
        public static string HW_UID { get; private set; }

        static HW_UID_ENGINE()
        {
            var cpuId = CpuId.GetCpuId();
            var windowsId = WindowsId.GetWindowsId();
            HW_UID = windowsId + cpuId;
        }
    }
}