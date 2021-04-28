using Autofac;

namespace Aspenlaub.Net.GitHub.CSharp.Chab {
    public static class ChabStandardContainerBuilder {
        public static ContainerBuilder UseChabStandard(this ContainerBuilder builder) {
            builder.RegisterType<Oven>().As<IOven>();
            return builder;
        }
    }
}
