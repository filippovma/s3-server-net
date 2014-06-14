﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Api.Filesystem
{
    public interface IFilesystemProvider
    {
        bool Exists(string path);
        IList<string> GetBucketList();
        DateTime GetBucketCreationDateTime(string bucketName);
        Stream StreamOfFile(string fileName);
        string ReadToEnd(string fileName);
    }
}
