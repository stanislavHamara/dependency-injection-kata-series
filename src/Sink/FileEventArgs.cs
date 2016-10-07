namespace Sink
{
    public class FileEventArgs
    {
        public string RelativePath { get; set; }

        public FileEventArgs(string relativePath)
        {
            RelativePath = relativePath;
        }
    }
}