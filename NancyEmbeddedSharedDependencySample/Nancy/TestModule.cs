namespace NancyEmbeddedSharedDependencySample.Nancy
{
    using System;
    using Dependencies;
    using global::Nancy;

    public class TestModule : NancyModule
    {
        public TestModule(IUpFrontDependency dependency, Func<IDelayedDependency> delayedDependency)
        {
            Get["/dependency"] = _ => dependency.Text;

            Get["/delayed"] = _ => delayedDependency().Text;
        }
    }
}