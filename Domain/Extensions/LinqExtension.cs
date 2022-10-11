using api_test.Domain.Entities;

namespace api_test.Domain.Extensions
{
    public static class LinqExtension
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
        public static PagedResult<TEntity> PaginatedSearchBase<TEntity>(this IEnumerable<TEntity> source, int page, int pageSize) where TEntity : class
        {
            var totalSize = source.Count();
            source = source.Skip((page * pageSize) - pageSize).Take(pageSize);

            return new PagedResult<TEntity>(page, pageSize, (totalSize / pageSize), totalSize, source.AsQueryable());
        }
    }
}
