namespace Quepland
{
    public class EntityDataService
    {
        public RoomManagerService Rooms { get; } = new RoomManagerService();
        public PetManagerService Pets { get; } = new PetManagerService();

        public EntityDataService() { }
    }
}
