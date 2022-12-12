using tests.Core;

namespace tests.Application
{
    public class TestService : IDynamicApiController, ITransient
    {
        private IRepository<AadUser> _repository;

        public TestService(IRepository<AadUser> repository)
        {
            _repository = repository;
        }

        public string GetTest()
        {
            return "让 .NET 开发更简单，更通用，更流行。";
        }

        public List<AadUser> GetAll()
        {
            return _repository.Where(x => true).ToList();
        }
    }
}