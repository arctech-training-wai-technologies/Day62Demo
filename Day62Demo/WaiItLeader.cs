class WaiItLeader<K>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public K responsibility { get; set; }

    public void Jump<T>(T param)
    {
        //Console.WriteLine()
    }
}