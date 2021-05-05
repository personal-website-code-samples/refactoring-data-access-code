namespace RefactorDataAccess.Responses
{
    using System.Collections.Generic;
    using Domain;

    public class GetWidgetsByTypeAndBatchNumberResponse
    {
        public GetWidgetsByTypeAndBatchNumberResponse(IReadOnlyList<Widget> widgets)
        {
            Widgets = widgets;
        }

        public IReadOnlyList<Widget> Widgets { get; }
    }
}
