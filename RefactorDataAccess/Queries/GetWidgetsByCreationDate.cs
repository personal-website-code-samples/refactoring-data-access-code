namespace RefactorDataAccess.Queries
{
    using System;

    public class GetWidgetsByCreationDate
    {
        public GetWidgetsByCreationDate(DateTime creationDate)
        {
            CreationDate = creationDate;
        }

        public DateTime CreationDate { get; }
    }
}
