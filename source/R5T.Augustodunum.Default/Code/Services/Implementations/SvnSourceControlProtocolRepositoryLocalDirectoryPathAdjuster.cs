using System;

using R5T.Lombardy;


namespace R5T.Augustodunum.Default
{
    public class SvnSourceControlProtocolRepositoryLocalDirectoryPathAdjuster : ISourceControlProtocolRepositoryLocalDirectoryPathAdjuster
    {
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public SvnSourceControlProtocolRepositoryLocalDirectoryPathAdjuster(IStringlyTypedPathOperator stringlyTypedPathOperator)
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
