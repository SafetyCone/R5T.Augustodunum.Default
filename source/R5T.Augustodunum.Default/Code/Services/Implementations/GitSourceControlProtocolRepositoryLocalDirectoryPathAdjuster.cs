using System;

using R5T.Lombardy;using R5T.T0064;


namespace R5T.Augustodunum.Default
{[ServiceImplementationMarker]
    /// <summary>
    /// Adjusts local directory paths 
    /// </summary>
    public class GitSourceControlProtocolRepositoryLocalDirectoryPathAdjuster : ISourceControlProtocolRepositoryLocalDirectoryPathAdjuster,IServiceImplementation
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
