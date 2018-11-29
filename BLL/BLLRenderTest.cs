using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class BLLRenderSingleton : IRenderScoped
    {
        public Guid getGuidNow { get; private set; } = Guid.NewGuid();
    }

    public class BLLRenderScoped : IRenderScoped
    {
        public Guid getGuidNow { get; private set; } = Guid.NewGuid();
    }

    public class BLLRenderTransient : IRenderTransient
    {
        public Guid getGuidNow { get; private set; } = Guid.NewGuid();
    }
}
