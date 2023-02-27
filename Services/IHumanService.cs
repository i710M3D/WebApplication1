namespace WebApplication1.Services
{
    public interface IHumanService
    {
        Task<List<Human>> GetALL();
        Task<Human> GetSingal(int id);
        Task<List<Human>> PostHuman(Human human);
        Task<List<Human>> UpdateSingal(int id , Human req);

        Task<List<Human>> DeleteHuman(int id);

    }
}
