using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Owleet.Models.DataRepository
{
    public interface ITestDataRepository : IGenericDataRepository<Test>
    {
        Task<List<Test>> GetPassedTestsByUserId(Guid id);
        Task<List<Test>> GetAllTests();
        Task<List<Test>> GetTestsByUserId(string id);
        Task<Test> GetTest(Guid id);
    }
}