
//a way of filtering based on an ISpecification<T>
using System.Collections.Generic;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
}