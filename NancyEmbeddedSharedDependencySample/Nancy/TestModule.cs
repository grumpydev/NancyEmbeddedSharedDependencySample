namespace NancyEmbeddedSharedDependencySample.Nancy
{
    using System;
    using Dependencies;
    using global::Nancy;

    public class TestModule : NancyModule
    {
        /// <summary>
        /// Test module
        /// </summary>
        /// <param name="dependency">The up front created dependency</param>
        /// <param name="delayedDependency">The func creates a "lazy factory" for dependencies that may not exist</param>
        public TestModule(IUpFrontDependency dependency, Func<IDelayedDependency> delayedDependency)
        {
            Get["/dependency"] = _ => dependency.Text;

            Get["/delayed"] = _ => delayedDependency().Text;
        }
    }
}