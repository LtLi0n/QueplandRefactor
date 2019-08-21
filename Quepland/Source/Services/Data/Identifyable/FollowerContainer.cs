namespace Quepland
{
    public class FollowerContainer : StoredEntityContainerBase<Follower, int>
    {
        public FollowerContainer() : base("data/followers.json") { }
    }
}
