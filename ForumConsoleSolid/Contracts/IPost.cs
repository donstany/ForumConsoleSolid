namespace ForumConsoleSolid.Contracts
{
    public interface IPost
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public IUser Author { get; set; }
    }
}