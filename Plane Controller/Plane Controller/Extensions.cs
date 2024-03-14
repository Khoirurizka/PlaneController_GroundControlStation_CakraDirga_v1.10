using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plane_Controller
{
    public static class Extensions
    {
        public static T AwaitSync<T>(this Task<T> infunc)
        {
            var tsk = Task.Run<T>(async () =>
            {
                return await infunc.ConfigureAwait(false);
            });

            return tsk.GetAwaiter().GetResult();
        }
    }
}
