namespace RefactorDataAccess.RepositoryPattern
{
    using System.Linq;
    using System.Threading.Tasks;
    using Common;
    using Infrastructure;
    using Microsoft.EntityFrameworkCore;
    using Queries;
    using Responses;

    public class OldWidgetService : IWidgetService
    {
        private readonly ApplicationContext _context;
        private readonly IWidgetFactory _widgetFactory;

        public OldWidgetService(ApplicationContext context, IWidgetFactory widgetFactory)
        {
            _context = context;
            _widgetFactory = widgetFactory;
        }

        public async Task<GetWidgetsByTypeAndBatchNumberResponse> Handle(GetWidgetsByTypeAndBatchNumber query)
        {
            var widgets = await _context.Widgets
                .Where(widget => widget.WidgetType == query.WidgetType)
                .Where(widget => widget.BatchNumber == query.BatchNumber)
                .ToListAsync();

            return _widgetFactory.TypeAndBatchNumberResponse(widgets);
        }

        public async Task<GetWidgetsByBatchNumberResponse> Handle(GetWidgetsByBatchNumber query)
        {
            var widgets = await _context.Widgets
                .Where(widget => widget.BatchNumber == query.BatchNumber)
                .ToListAsync();

            return _widgetFactory.BatchNumberResponse(widgets);
        }

        public async Task<GetWidgetsByCreationDateResponse> Handle(GetWidgetsByCreationDate query)
        {
            var widgets = await _context.Widgets
                .Where(widget => widget.CreatedOn == query.CreationDate)
                .ToListAsync();

            return _widgetFactory.CreationDateResponse(widgets);
        }

        public async Task<GetWidgetsByBatchNumberAndCreationDateResponse> Handle(GetWidgetsByBatchNumberAndCreationDate query)
        {
            var widgets = await _context.Widgets
                .Where(widget => widget.BatchNumber == query.BatchNumber)
                .Where(widget => widget.CreatedOn == query.CreationDate)
                .ToListAsync();

            return _widgetFactory.BatchNumberAndCreationDateResponse(widgets);
        }
    }
}
