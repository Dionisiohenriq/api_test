using System.Linq;

namespace api_test.Domain.Entities
{
    public class PagedResult<TEntity> where TEntity : class
    {
        public int PageNumber { get; private set; }
        public int PageSize { get; private set; }

        public int PageCount { get; private set; }

        public int RowCount { get; private set; }

        public IQueryable<TEntity> ContentList { get; private set; }

        public PagedResult(int _pageNumber, int _pageSize, int _pageCount, int _rowCount, IQueryable<TEntity> _contentList)
        {
            PageNumber = _pageNumber;
            PageSize = _pageSize;
            PageCount = _pageCount;
            RowCount = _rowCount;
            ContentList = _contentList;
        }
    }
}
