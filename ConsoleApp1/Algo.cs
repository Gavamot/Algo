static class Algo
{
    public static IEnumerable<T[]> Combinations<T>(this IEnumerable<T> source)
    {
        return permutate(source, Enumerable.Empty<T>());
        IEnumerable<T[]> permutate(IEnumerable<T> reminder, IEnumerable<T> prefix)
        {
            var enumerable = reminder as T[] ?? reminder.ToArray();
            return !enumerable.Any()
                ? new[] { prefix.ToArray() }
                : enumerable.SelectMany((c, i) => permutate(
                    enumerable.Take(i).Concat(enumerable.Skip(i + 1)).ToArray(),
                    prefix.Append(c)));
        }
    }
}