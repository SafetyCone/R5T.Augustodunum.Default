using System;

using R5T.Lombardy;


namespace R5T.Augustodunum.Default
{
    /// <summary>
    /// Adjusts local directory paths 
    /// </summary>
    public class GitSourceControlProtocolRepositoryLocalDirectoryPathAdjuster : ISourceControlProtocolRepositoryLocalDirectoryPathAdjuster
    {
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public GitSourceControlProtocolRepositoryLocalDirectoryPathAdjuster(IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string AdjustLocalDirectoryPath(string localDirectoryPath)
        {
            var adjustedPath = this.StringlyTypedPathOperator.EnsureNotDirectoryIndicatedPath(localDirectoryPath);
            return adjustedPath;
        }
    }
}
