namespace SolidApi.Interfaces
{
    public interface INameDetails
    {
        string Title { get; init; }
        string Given { get; init; }
        string Middle { get; init; }
        string Family { get; init; }
        string Prefix { get; init; }
        string Suffix { get; init; }
        string Other { get; init; }
    }
}