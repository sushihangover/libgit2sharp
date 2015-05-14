using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal class GitFetchOptions
    {
        GitRemoteCallbacks remote_callbacks;
        FetchPruneStrategy prune;
        int update_fetchhead;
        TagFetchMode download_tags;
    }
}
