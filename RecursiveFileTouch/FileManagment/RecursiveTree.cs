using System;
using System.Collections.Specialized;
using System.IO;

namespace RecursiveFileTouch.FileManagment
{
    public class RecursiveTree
    {
        static StringCollection log = new StringCollection();

        public void WalkDirectoryTreeCallback(Object callbackParams)//, Object delegateMethod)
        {
            CallbackParams param = (CallbackParams)callbackParams;

            WalkDirectoryTreeExecuteDelegateOnAFile((DirectoryInfo)param.RootDirectory, (Action<String>)param.DelegateMethod);
        }

        public void WalkDirectoryTreeExecuteDelegateOnAFile(DirectoryInfo root, Action<String> method)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirectories = null;

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            // This is thrown if even one of the files requires permissions greater
            // than the application provides.
            catch (UnauthorizedAccessException e)
            {
                // This code just writes out the message and continues to recurse.
                // You may decide to do something different here. For example, you
                // can try to elevate your privileges and access the file again.
                log.Add(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    // In this example, we only access the existing FileInfo object. If we
                    // want to open, delete or modify the file, then
                    // a try-catch block is required here to handle the case
                    // where the file has been deleted since the call to TraverseTree().
                    Console.WriteLine(fi.FullName);
                    method(fi.FullName);
                }

                // Now find all the subdirectories under this directory.
                subDirectories = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirectories)
                {
                    // Resursive call for each subdirectory.
                    WalkDirectoryTreeExecuteDelegateOnAFile(dirInfo, method);
                }
            }
        }
    }

    public class CallbackParams
    {
        private Object rootDirectory;

        public Object RootDirectory
        {
            get { return rootDirectory; }
            set { rootDirectory = value; }
        }
        private Object delegateMethod;

        public Object DelegateMethod
        {
            get { return delegateMethod; }
            set { delegateMethod = value; }
        }

    }
}
