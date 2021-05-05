namespace RefactorDataAccess.Responses
{
    using System.Collections.Generic;
    using Domain;

    public class GetWidgetsByBatchNumberResponse
    {
        public GetWidgetsByBatchNumberResponse(IReadOnlyList<Widget> widgets)
        {
            Widgets = widgets;
        }

        public IReadOnlyList<Widget> Widgets { get; }
    }
}
