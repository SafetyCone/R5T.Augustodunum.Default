using System;

using R5T.Magyar.Extensions;


namespace R5T.Augustodunum.Default
{
    /// <summary>
    /// Adjusts mapping repository URLs as required for the git source control protocol.
    /// </summary>
    public class SvnSourceControlProtocolRepositoryUrlAdjuster : ISourceControlProtocolRepositoryUrlAdjuster
    {
        public string AdjustRepositoryUrl(string repositoryUrl)
        {
            // Adust for possible Git-style repository URLs.
            var lastFour = repositoryUrl.Last(4);

            var gitTerminated = lastFour == ".git";

            var adjustedRepositoryUrl = gitTerminated ? repositoryUrl + "/trunk" : repositoryUrl;

            return adjustedRepositoryUrl;
        }
    }
}
