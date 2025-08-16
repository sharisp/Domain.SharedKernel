namespace Domain.SharedKernel.Interfaces
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// SaveChangesAsync
        /// </summary>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns></returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges();
    }
}
