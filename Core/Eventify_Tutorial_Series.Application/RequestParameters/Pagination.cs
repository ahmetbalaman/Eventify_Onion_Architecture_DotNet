namespace Eventify_Tutorial_Series.Application.RequestParameters;

public record Pagination(int PageCount = 0, int ItemCount = 5);