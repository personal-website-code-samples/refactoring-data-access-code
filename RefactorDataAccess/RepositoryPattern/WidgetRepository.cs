namespace RefactorDataAccess.RepositoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Domain;
    using Infrastructure;
    using Microsoft.EntityFrameworkCore;

    public class WidgetRepository : IWidgetRepository
    {
        private readonly ApplicationContext _context;

        public WidgetRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Widget>> SearchTypeWithBatchNumber(WidgetType widgetType, int batchNumber)
        {
            return await _context.Widgets
                .Where(widget => widget.WidgetType == widgetType)
                .Where(widget => widget.BatchNumber == batchNumber)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<Widget>> SearchBatchNumber(int batchNumber)
        {
            return await _context.Widgets
                .Where(widget => widget.BatchNumber == batchNumber)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<Widget>> SearchCreationDate(DateTime createdOn)
        {
            return await _context.Widgets
                .Where(widget => widget.CreatedOn == createdOn)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<Widget>> SearchBatchNumberOnDate(int batchNumber, DateTime createdOn)
        {
            return await _context.Widgets
                .Where(widget => widget.BatchNumber == batchNumber)
                .Where(widget => widget.CreatedOn == createdOn)
                .ToListAsync();
        }
    }
}
