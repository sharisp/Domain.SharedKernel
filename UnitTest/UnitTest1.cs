using Domain.SharedKernel;
using Domain.SharedKernel.HelperFunctions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private ServiceProvider _serviceProvider;

        //  private AuthenticationTokenResponse authenticationTokenResponse;
        [TestInitialize] // run before each test
        public void Setup()
        {
            var services = new ServiceCollection();
            services.AddDomainShardKernelCollection(new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build());
            _serviceProvider = services.BuildServiceProvider();
            // authenticationTokenResponse = _serviceProvider.GetService<AuthenticationTokenResponse>();

        }

        [TestCleanup]
        public void Cleanup()
        {
            if (_serviceProvider != null)
            {
                _serviceProvider.Dispose();
            }
        }


        [TestMethod]
        public void Test1()
        {
            IdGeneratorFactory.Initialize(1);
            var newID = IdGeneratorFactory.NewId();
            Assert.IsTrue(newID > 0, "newID should have value");
        }

        [TestMethod]
        public void Test2()
        {
            var newID = IdGeneratorFactory.NewId();
            Assert.IsTrue(newID > 0, "newID should have value");
        }

        [TestMethod]
        public void TestMd5()
        {
            var md5Str = HashHelper.ComputeMd5Hash("test string");
            Assert.IsNotNull(md5Str, "Hash should not be null");

            Assert.IsTrue(md5Str.Length > 0, "Hash length should be greater than 0");
        }

        [TestMethod]
        public void TestSha256()
        {
            var str = HashHelper.ComputeSha256Hash("test string");
            Assert.IsNotNull(str, "Hash should not be null");

            Assert.IsTrue(str.Length > 0, "Hash length should be greater than 0");
        }
    }
}