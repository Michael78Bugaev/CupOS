using Cosmos.Core.Memory;
using Cup.sys.gui;
using Cup.sys.io;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace Cup.sys.core
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.Write("Initiliazing IO subsystem...");
            IO.Init();
            Thread.Sleep(200);
            Console.Clear();
            Console.Write("Starting GUI...");
            Thread.Sleep(2000);
            GUI.Enable();
        }

        protected override void Run()
        {
            GUI.canvas.Clear();
            // First layer
            GUI.DrawDesktop();

            // Last layer
            GUI.DrawMouse();

            Heap.Collect();
            GUI.canvas.Display();
        }
    }
}
