using System;
using System.Collections;
using System.Collections.Generic;

namespace MyNamespace
{
    public class MyClass
    {
        static void Main()
        {
            GC.Collect(2, GCCollectionMode.Optimized);
            Console.WriteLine("GC");

            OperatingSystem os = Environment.OSVersion;
            PlatformID pid = os.Platform;
            Console.WriteLine(pid);

            Console.WriteLine(PlatformID.Win32NT);
            Console.WriteLine(SoundID.SE_CANCEL);
        }
    }

    public Dictionary<SoundID, string> sid2fn = new Dictionary<SoundID, string>()
    {
        {SoundID.SE_DECIDE, "test1"},
        {SoundID.SE_CANCEL, "test2"},
        {SoundID.SE_SELL  , "test3"}
    }

    public enum SoundID
    {
        SE_DECIDE = 1,
        SE_CANCEL = 2,
        SE_SELL   = 3
    }

    struct MyStruct
    {}

    interface IMyInterface
    {}

    delegate int MyDelegate();

    enum MyEnum
    {}

}
