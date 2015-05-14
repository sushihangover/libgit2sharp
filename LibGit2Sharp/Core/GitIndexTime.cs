using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal class GitIndexTime
    {
        public uint seconds;
        public uint nanoseconds;
    }
}
