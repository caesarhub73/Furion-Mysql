using Furion;
using System.Reflection;

namespace tests.Web.Entry
{
    public class SingleFilePublish : ISingleFilePublish
    {
        public Assembly[] IncludeAssemblies()
        {
            return Array.Empty<Assembly>();
        }

        public string[] IncludeAssemblyNames()
        {
            return new[]
            {
            "tests.Application",
            "tests.Core",
            "tests.EntityFramework.Core",
            "tests.Web.Core"
        };
        }
    }
}