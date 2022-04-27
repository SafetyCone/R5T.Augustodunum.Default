using System;

using R5T.Lombardy;using R5T.T0064;


namespace R5T.Augustodunum.Default
{[ServiceImplementationMarker]
    public class SvnSourceControlProtocolRepositoryLocalDirectoryPathAdjuster : ISourceControlProtocolRepositoryLocalDirectoryPathAdjuster,IServiceImplementation
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
