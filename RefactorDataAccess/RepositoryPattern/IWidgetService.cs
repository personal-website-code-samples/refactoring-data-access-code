namespace RefactorDataAccess.RepositoryPattern
{
    using System.Threading.Tasks;
    using Queries;
    using Responses;

    public interface IWidgetService
    {
        Task<GetWidgetsByTypeAndBatchNumberResponse> Handle(GetWidgetsByTypeAndBatchNumber query);

        Task<GetWidgetsByBatchNumberResponse> Handle(GetWidgetsByBatchNumber query);

        Task<GetWidgetsByCreationDateResponse> Handle(GetWidgetsByCreationDate query);

        Task<GetWidgetsByBatchNumberAndCreationDateResponse> Handle(GetWidgetsByBatchNumberAndCreationDate query);
    }
}
