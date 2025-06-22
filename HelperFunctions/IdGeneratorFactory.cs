using IdGen;

namespace Domain.SharedKernel.HelperFunctions
{
    public static class IdGeneratorFactory
    {
        private static IdGenerator _generator;

        public static void Initialize(int workerId)
        {
            _generator = new IdGenerator(workerId);
        }

        // private static readonly IdGenerator _generator = new IdGenerator(0);

        public static long NewId() => _generator.CreateId();
    }
}
