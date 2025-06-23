using IdGen;

namespace Domain.SharedKernel.HelperFunctions
{
    public static class IdGeneratorFactory
    {
        private static IdGenerator? _generator;
        private static readonly object _lock = new();
        private static bool _initialized = false;

        public static void Initialize(int workerId)
        {
            lock (_lock)
            {
                if (_initialized) return; 

                _generator = new IdGenerator(workerId);
                _initialized = true;
            }
        }

        public static long NewId()
        {
            if (_generator == null)
                throw new InvalidOperationException("IdGeneratorFactory is not initialized. Call Initialize() first.");

            return _generator.CreateId();
        }
    }

}
