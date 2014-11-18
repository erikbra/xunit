using Windows.ApplicationModel;
using Windows.Storage;

namespace System.IO
{
    internal static class File
    {
        public static bool Exists(string path)
        {
            return GetStorageFile(path) != null;
        }

        public static Stream OpenRead(string path)
        {
            throw new NotImplementedException();
        }

        // Helpers

        static StorageFile GetStorageFile(string path)
        {
            if (String.IsNullOrWhiteSpace(path))
                return null;

            var folder = Package.Current.InstalledLocation;

            if (!path.Contains(folder.Path))
                return null;

            var fileName = Path.GetFileName(path);
            var fileAsync = folder.GetFileAsync(fileName);

            try
            {
                fileAsync.AsTask().Wait();
                return fileAsync.GetResults();
            }
            catch
            {
                return null;
            }
        }

        public static Stream OpenRead(string path)
        {
            throw new NotImplementedException();
        }
    }
}
