var p1 = new Pair<int[], int>(new[] {3}, 5);
//var p2 = new Pair<int, string>(4, "четыре"); // Ошибка
// var p3 = new Pair<double, Pair<int, int>>(3.5, p1); // Ошибка 
Console.WriteLine(p1);

class Pair<T1, T2> where T1: IEnumerable<int>
{
    public T1 first { get; set;}
    public T2 second { get; set;}
    public Pair(T1 first, T2 second)
    {
        this.first = first;
        this.second = second;
    }
    //public void Test<T3>(T3 arg)
    //{
    //}
    public override string ToString() => $"({first}, {second})";
    public override bool Equals(object? obj) => obj is Pair<T1, T2> other && first.Equals(other.first) && second.Equals(other.second);
    public override int GetHashCode() => HashCode.Combine(first, second);
}
