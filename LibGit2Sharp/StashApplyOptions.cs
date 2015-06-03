using System;
using LibGit2Sharp.Core;
using LibGit2Sharp.Handlers;

namespace LibGit2Sharp
{
    /// <summary>
    /// The options to be used for stash application.
    /// </summary>
    public sealed class StashApplyOptions
    {
        /// <summary>
        /// <see cref="StashApplyModifiers"/> for controlling checkout index reinstating./> 
        /// </summary>
        /// <value>The flags.</value>
        public StashApplyModifiers ApplyModifiers { get; set; }

        /// <summary>
        /// <see cref="CheckoutOptions"/> controlling checkout behavior.
        /// </summary>
        /// <value>The checkout options.</value>
        public CheckoutOptions CheckoutOptions { get; set; }

        /// <summary>
        /// <see cref="StashApplyProgressHandler"/> for controlling stash application progress./>
        /// </summary>
        /// <value>The progress handler.</value>
        public StashApplyProgressHandler ProgressHandler { get; set; }
    }

    /// <summary>
    /// The flags which control whether the index should be reinstated.
    /// </summary>
    [Flags]
    public enum StashApplyModifiers
    {
        /// <summary>
        /// Default. Reinstate working directory stashed changes.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Reinstate both index and working directory stashed changes.
        /// </summary>
        ReinstateIndex = (1 << 0),
    }
}
