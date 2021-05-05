namespace RefactorDataAccess.Responses
{
    using System.Collections.Generic;
    using Domain;

    public class GetWidgetsByCreationDateResponse
    {
        public GetWidgetsByCreationDateResponse(IReadOnlyList<Widget> widgets)
        {
            Widgets = widgets;
        }

        public IReadOnlyList<Widget> Widgets { get; }
    }
}
