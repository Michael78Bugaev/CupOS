using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup.sys.io
{
    public static class IO
    {
        static CosmosVFS fs = new();
        public static string CurrentPath = @"0:\";
        public static void Init()
        {
            VFSManager.RegisterVFS(fs);
        }
    }
}
