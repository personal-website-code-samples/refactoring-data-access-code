namespace RefactorDataAccess.Queries
{
    using Domain;

    public class GetWidgetsByTypeAndBatchNumber
    {
        public GetWidgetsByTypeAndBatchNumber(WidgetType widgetType, int batchNumber)
        {
            WidgetType = widgetType;
            BatchNumber = batchNumber;
        }

        public WidgetType WidgetType { get; }

        public int BatchNumber { get; }
    }
}
