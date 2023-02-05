using System;

using R5T.Magyar.Extensions;using R5T.T0064;


namespace R5T.Augustodunum.Default
{
    /// <summary>
    /// Adjusts mapping repository URLs as required for the git source control protocol.
    /// </summary>
    [ServiceImplementationMarker]
    public class GitSourceControlProtocolRepositoryUrlAdjuster : ISourceControlProtocolRepositoryUrlAdjuster,IServiceImplementation
    {
        public string AdjustRepositoryUrl(string repositoryUrl)
        {
            // Adjust for possible SVN-style repository URLs.
            var lastSix = repositoryUrl.Last(6);

            var trunkTerminated = lastSix == "/trunk";

            var trunkAdjustedUrl = trunkTerminated ? repositoryUrl.ExceptLast(6) : repositoryUrl;

            // Ensure is git-style repository URL.
            var lastFour = trunkAdjustedUrl.Last(4);

            var gitTerminated = lastFour == ".git";

            if (!gitTerminated)
            {
                //throw new Exception($"Repository URL was NOT\".git\" terminated: {repositoryUrl}");
            }

            return trunkAdjustedUrl;
        }
    }
}
