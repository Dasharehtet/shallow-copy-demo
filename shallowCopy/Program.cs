// See https://aka.ms/new-console-template for more information

using shallowCopy;

var entry = new Entry
{
    MyProperty = "text"
};

var entryCopy = (Entry)entry.ShallowCopy();
entryCopy.MyProperty = "other";

entry.MyProperty = "one_more";

Console.WriteLine("Before ");
Console.WriteLine($"Original: {entry.MyProperty}, copy: {entryCopy.MyProperty}, one more: {entry.MyProperty}");