using RefactorDataAccess.Domain;
using RefactorDataAccess.Responses;
using System.Collections.Generic;

namespace RefactorDataAccess.Common
{
    public interface IWidgetFactory
    {
        GetWidgetsByBatchNumberAndCreationDateResponse BatchNumberAndCreationDateResponse(IEnumerable<Widget> widgets);

        GetWidgetsByBatchNumberResponse BatchNumberResponse(IEnumerable<Widget> widgets);

        GetWidgetsByCreationDateResponse CreationDateResponse(IEnumerable<Widget> widgets);

        GetWidgetsByTypeAndBatchNumberResponse TypeAndBatchNumberResponse(IEnumerable<Widget> widgets);
    }
}
