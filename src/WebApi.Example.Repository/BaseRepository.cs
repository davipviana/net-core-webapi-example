using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Example.Util;

namespace WebApi.Example.Repository
{
    [Intercept(typeof(MemoryCaching))]
    public class BaseRepository
    {
    }
}
