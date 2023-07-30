using System.Collections.Generic;

public static class CollectionExtensions
{
    public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> list){
        var collection = new OservableCollection<T>();
        foreach (var item in list)
        {
            collection.add(item);
        }
        return collection;
    }
}