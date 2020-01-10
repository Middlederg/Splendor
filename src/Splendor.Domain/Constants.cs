using System;
using System.Reflection;

namespace Splendor.Domain
{
    public static class Constants
    {
        public static Language CurrentLanguage = Language.English;
        public static Currency CurrentCurrency = Currency.FromCode("EUR");

        public const string RepoOwner = "Middlederg";
        public const string RepoName = "Splendor";
        public static string RepoLink = $"https://github.com/{RepoOwner}/{RepoName}";
        public static string LatestRelease = $"https://github.com/{RepoOwner}/{RepoName}/releases/latest";
        public static string LatestReleaseApiEndpoint = $"https://api.github.com/repos/{RepoOwner}/{RepoName}/releases/latest";
    }
}
