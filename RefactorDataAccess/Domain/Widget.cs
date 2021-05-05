namespace RefactorDataAccess.Domain
{
    using System;

    public class Widget
    {
        public Widget(Guid id, WidgetType widgetType, int batchNumber, DateTime createdOn)
        {
            Id = id;
            WidgetType = widgetType;
            BatchNumber = batchNumber;
            CreatedOn = createdOn;
        }

        public Guid Id { get; }

        public WidgetType WidgetType { get; }

        public int BatchNumber { get; }

        public DateTime CreatedOn { get; }
    }
}
