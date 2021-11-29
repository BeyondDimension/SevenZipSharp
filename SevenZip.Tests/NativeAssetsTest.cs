using NUnit.Framework;
using System.Reflection;

namespace SevenZip.Tests;

sealed class NativeAssetsTest
{
    [Test]
    public void LibraryFilePath()
    {
        var libFilePath = typeof(SevenZipBase).Assembly.GetType("SevenZip.SevenZipLibraryManager").GetMethod("DetermineLibraryFilePath", BindingFlags.Static | BindingFlags.NonPublic).Invoke(null, null);
        TestContext.WriteLine("libFilePath:");
        TestContext.WriteLine(libFilePath);
    }
}
