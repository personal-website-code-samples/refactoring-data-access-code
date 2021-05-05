namespace RefactorDataAccess.RepositoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain;

    public interface IWidgetRepository
    {
        // Removed other methods for clarity.

        Task<IReadOnlyList<Widget>> SearchTypeWithBatchNumber(WidgetType widgetType, int batchNumber);

        Task<IReadOnlyList<Widget>> SearchBatchNumber(int batchNumber);

        Task<IReadOnlyList<Widget>> SearchCreationDate(DateTime createdOn);

        Task<IReadOnlyList<Widget>> SearchBatchNumberOnDate(int batchNumber, DateTime createdOn);
    }
}
