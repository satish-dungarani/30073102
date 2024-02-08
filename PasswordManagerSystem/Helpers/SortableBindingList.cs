using System;
using System.Collections.Generic;
using System.ComponentModel;

public class SortableBindingList<T> : BindingList<T>
{
    private bool isSorted;
    private ListSortDirection sortDirection;
    private PropertyDescriptor sortProperty;

    public SortableBindingList(List<T> list) : base(list)
    {
    }

    protected override bool SupportsSortingCore => true;

    protected override bool IsSortedCore => isSorted;

    protected override ListSortDirection SortDirectionCore => sortDirection;

    protected override PropertyDescriptor SortPropertyCore => sortProperty;

    protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
    {
        var itemsList = (List<T>)Items;

        if (prop.PropertyType.GetInterface("IComparable") == null)
            throw new NotSupportedException("The specified property does not implement IComparable interface.");

        itemsList.Sort((a, b) =>
        {
            var valueA = prop.GetValue(a);
            var valueB = prop.GetValue(b);
            return direction == ListSortDirection.Ascending ?
                ((IComparable)valueA).CompareTo(valueB) :
                ((IComparable)valueB).CompareTo(valueA);
        });

        isSorted = true;
        sortDirection = direction;
        sortProperty = prop;

        OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
    }

    protected override void RemoveSortCore()
    {
        isSorted = false;
        sortDirection = ListSortDirection.Ascending;
        sortProperty = null;
    }
}
