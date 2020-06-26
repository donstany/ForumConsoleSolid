namespace ForumConsoleSolid.Contracts
{
    public interface ICommand : IExecutable
    {
        IForum Forum { get; }
    }
}
