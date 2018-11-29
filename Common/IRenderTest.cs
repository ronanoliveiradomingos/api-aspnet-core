using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public interface IRenderTest
    {
        Guid getGuidNow { get; }
    }

    public interface IRenderSingleton : IRenderTest
    {

    }

    public interface IRenderScoped : IRenderTest
    {

    }

    public interface IRenderTransient : IRenderTest
    {

    }

}
