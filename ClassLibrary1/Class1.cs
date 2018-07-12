using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Test()
        {
            var t = new Other.Test();
            t.TryGet(out _);
        }
    }
}
namespace Other
{
    public class Test
    {
        public bool TryGet(out int i)
        {
            i = 5;
            return true;
        }
    }
}
