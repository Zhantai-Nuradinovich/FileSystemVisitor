using System;
using System.Text.RegularExpressions;
using Xunit;

namespace FileSystemVisitor.Tests
{
    public class FileSystemVisitor_Mode
    {
        [Theory]
        [InlineData("[1-5]", "C:\\Users\\Zhantai\\Desktop\\Papka\\Papka\\1")]
        [InlineData("[4]", "")]
        [InlineData("", "C:\\Users\\Zhantai\\Desktop\\Papka\\Papka\\Papka;C:\\Users\\Zhantai\\Desktop\\Papka\\Papka\\1")]
        public void GetFileSystemEntriese_ContainsDigits_ReturnsNumericFilesAndFolders(string input, string expected)
        {
            var _visitor = new FileSystemVisitor(path =>
                        {
                            var regex = new Regex(input);
                            return regex.IsMatch(path);
                        });
            var fileSystemEntries = _visitor.GetFileSystemEntries("C:\\Users\\Zhantai\\Desktop\\Papka\\Papka");
            var result = string.Join(';', fileSystemEntries);

            Assert.Equal(expected, result);
        }
    }
}
