using System;

namespace RefactorDataAccess.Queries
{
    public class GetWidgetsByBatchNumberAndCreationDate
    {
        public GetWidgetsByBatchNumberAndCreationDate(int batchNumber, DateTime creationDate)
        {
            BatchNumber = batchNumber;
            CreationDate = creationDate;
        }

        public int BatchNumber { get; }

        public DateTime CreationDate { get; }
    }
}
