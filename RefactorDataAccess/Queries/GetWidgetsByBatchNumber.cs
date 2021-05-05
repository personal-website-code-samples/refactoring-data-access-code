namespace RefactorDataAccess.RepositoryPattern
{
    public class GetWidgetsByBatchNumber
    {
        public GetWidgetsByBatchNumber(int batchNumber)
        {
            BatchNumber = batchNumber;
        }

        public int BatchNumber { get; }
    }
}
