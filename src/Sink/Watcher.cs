using System;
using System.IO;

namespace Sink
{
    public class Watcher
    {
        private readonly FileSystemWatcher _fileSystemWatcher;

        public Watcher()
        {
            _fileSystemWatcher = new FileSystemWatcher
            {
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName
            };

            _fileSystemWatcher.Created += OnCreated;
            _fileSystemWatcher.Deleted += OnDeleted;
        }

        public void StartWatching(string path)
        {
            _fileSystemWatcher.Path = path;
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        public event EventHandler<FileEventArgs> FileAdded;

        public event EventHandler<FileEventArgs> FileDeleted;

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            FileAdded?.Invoke(sender, EventArgsFrom(e));
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            FileDeleted?.Invoke(sender, EventArgsFrom(e));
        }

        private FileEventArgs EventArgsFrom(FileSystemEventArgs e)
        {
            return new FileEventArgs(ToRelative(e.FullPath));
        }

        private string ToRelative(string path)
        {
            var folder = _fileSystemWatcher.Path;
            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                folder += Path.DirectorySeparatorChar;
            }

            var folderUri = new Uri(folder);
            var pathUri = new Uri(path);
            return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }
    }
}