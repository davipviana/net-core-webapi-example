using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Example.Util
{
    public class MemoryCaching : IInterceptor
    {
        private Dictionary<string, object> cache = new Dictionary<string, object>();
        
        public void Intercept(IInvocation invocation)
        {
            var isCachedMethod = invocation
                                    .TargetType
                                    .GetMethod(invocation.Method.Name)
                                    .CustomAttributes.Any(a => a.AttributeType == typeof(CacheMethodAttribute));

            if (isCachedMethod)
            {
                var name = $"{invocation.Method.DeclaringType}_{invocation.Method.Name}";
                var args = string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()));
                var cacheKey = $"{name}|{args}";

                cache.TryGetValue(cacheKey, out object returnValue);
                if (returnValue == null)
                {
                    invocation.Proceed();
                    returnValue = invocation.ReturnValue;
                    cache.Add(cacheKey, returnValue);
                }
                else
                {
                    invocation.ReturnValue = returnValue;
                }
            }
            else
            {
                invocation.Proceed();
            }   
        }
    }
}
