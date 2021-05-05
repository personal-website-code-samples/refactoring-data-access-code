using RefactorDataAccess.Domain;
using System.Collections.Generic;

namespace RefactorDataAccess.Responses
{
    public class GetWidgetsByBatchNumberAndCreationDateResponse
    {
        public GetWidgetsByBatchNumberAndCreationDateResponse(IReadOnlyList<Widget> widgets)
        {
            Widgets = widgets;
        }

        public IReadOnlyList<Widget> Widgets { get; }
    }
}
