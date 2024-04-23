namespace Eventify_Tutorial_Series.Domain.Common;

public class EntityBase<TKey>
{
    public TKey Id { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset? UpdatedDate { get; set; }
}