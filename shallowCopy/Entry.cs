namespace shallowCopy;

public class Entry
{
    public Entry()
    {
        throw new NotImplementedException();
    }

    public string MyProperty { get; set; }

    public object ShallowCopy()
    { return MemberwiseClone(); }
}