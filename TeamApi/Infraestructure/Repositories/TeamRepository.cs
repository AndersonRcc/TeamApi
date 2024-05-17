using Microsoft.EntityFrameworkCore;
using PARCIALDB.DOMAIN.Core.Entities;
using PARCIALDB.DOMAIN.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamApi.Core.Interfaces;

namespace PARCIALDB.DOMAIN.Infraestructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly Parcial20240120100738Context _dbContext;

        public TeamRepository(Parcial20240120100738Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Insert(Team team)
        {
            await _dbContext.Team.AddAsync(team);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Update(Team team)
        {
            _dbContext.Team.Update(team);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var findCategory = await _dbContext
                .Team
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (findCategory == null) return false;

            _dbContext.Team.Remove(findCategory);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }
        public async Task<IEnumerable<Team>> GetAll()
        {
            return await _dbContext
                    .Team
                    .ToListAsync();
        }
    }
}