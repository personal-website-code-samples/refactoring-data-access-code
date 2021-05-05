namespace RefactorDataAccess.RepositoryPattern
{
    using System.Threading.Tasks;
    using Common;
    using Queries;
    using Responses;

    public class UpdatedWidgetService : IWidgetService
    {
        private readonly IWidgetRepository _widgetRepository;
        private readonly IWidgetFactory _widgetFactory;

        public UpdatedWidgetService(IWidgetRepository widgetRepository, IWidgetFactory widgetFactory)
        {
            _widgetRepository = widgetRepository;
            _widgetFactory = widgetFactory;
        }

        public async Task<GetWidgetsByTypeAndBatchNumberResponse> Handle(GetWidgetsByTypeAndBatchNumber query)
        {
            var widgets = await _widgetRepository.SearchTypeWithBatchNumber(query.WidgetType, query.BatchNumber);

            return _widgetFactory.TypeAndBatchNumberResponse(widgets);
        }

        public async Task<GetWidgetsByBatchNumberResponse> Handle(GetWidgetsByBatchNumber query)
        {
            var widgets = await _widgetRepository.SearchBatchNumber(query.BatchNumber);

            return _widgetFactory.BatchNumberResponse(widgets);
        }

        public async Task<GetWidgetsByCreationDateResponse> Handle(GetWidgetsByCreationDate query)
        {
            var widgets = await _widgetRepository.SearchCreationDate(query.CreationDate);

            return _widgetFactory.CreationDateResponse(widgets);
        }

        public async Task<GetWidgetsByBatchNumberAndCreationDateResponse> Handle(GetWidgetsByBatchNumberAndCreationDate query)
        {
            var widgets = await _widgetRepository.SearchBatchNumberOnDate(query.BatchNumber, query.CreationDate);

            return _widgetFactory.BatchNumberAndCreationDateResponse(widgets);
        }
    }
}
