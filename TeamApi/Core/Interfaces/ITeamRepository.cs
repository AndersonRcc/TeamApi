using PARCIALDB.DOMAIN.Core.Entities;

namespace TeamApi.Core.Interfaces
{
    public interface ITeamRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Team>> GetAll();
        Task<bool> Insert(Team team);
        Task<bool> Update(Team team);
    }
}