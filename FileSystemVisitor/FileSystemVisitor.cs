using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemVisitor
{
    public class FileSystemVisitor
    {
        public event EventHandler<TraversionStatusEventArgs> TraversionStatusEventHandler;

        Predicate<string> _matches;
        public FileSystemVisitor() { }

        public FileSystemVisitor(Predicate<string> matches) : this()
        {
            _matches = matches;
        }

        public string[] GetFileSystemEntries(string path)
        {
            var fileSystemEntries = GetLeavesByDepth(path).Where(x => x != path && !string.IsNullOrWhiteSpace(x)).ToArray();
            return fileSystemEntries;
        }
        private IEnumerable<string> GetLeavesByDepth(string rootPath)
        {
            var visited = new HashSet<string>();
            var stack = new Stack<string>();
            stack.Push(rootPath);
            InvokeTraversionStatusEventhandler("Starting traversion of file system..");

            while (stack.Count != 0)
            {
                var current = stack.Pop();
                if (!visited.Add(current))
                    continue;

                var childDirs = Directory.GetDirectories(current);
                var files = Directory.GetFiles(current).ToList();
                files.Add(current);
                InvokeTraversionStatusEventhandler("Entries found: ", files);

                foreach (var dir in childDirs)
                    stack.Push(dir);

                if(_matches != null)
                {
                    files = files.Where(x => _matches(x)).ToList();
                    if(files.Count > 0)
                        InvokeTraversionStatusEventhandler("Filtered entries found: ", files);
                }

                yield return string.Join('\n', files);
            }
            InvokeTraversionStatusEventhandler("Finished!");
        }

        void InvokeTraversionStatusEventhandler(string message, List<string> files = null)
        {
            if (TraversionStatusEventHandler != null)
            {
                string foundFiles = files != null 
                    ? string.Join('\n', files)
                    : "" ;
                TraversionStatusEventHandler(this, new TraversionStatusEventArgs(message, foundFiles));
                Thread.Sleep(1000);
            }
        }
    }

    public class TraversionStatusEventArgs : EventArgs
    {
        public string Message { get; set; }
        public string FoundFiles{ get; set; }
        public TraversionStatusEventArgs() : base() 
        { }
        public TraversionStatusEventArgs(string message, string foundFiles) : this()
        {
            Message = message;
            FoundFiles = foundFiles;
        }
    }
}
