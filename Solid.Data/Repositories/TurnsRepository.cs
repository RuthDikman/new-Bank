using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class TurnsRepository:ITurnsRepositories
    {
        private readonly DataContext _context;

        public TurnsRepository(DataContext context)
        {
            _context = context;
        }
        public Turn AddTurn(Turn turn)
        {
            _context.Turns.Add(turn);
            return turn;
        }

        public void DeleteTurn(int id)
        {
            var temp = _context.Turns.Find(x => x.Id == id);
            _context.Turns.Remove(temp);
        }

        public List<Turn> GetTurns()
        {
            return _context.Turns;
        }

        public Turn GetByStart(DateTime start)
        {
            return _context.Turns.Find(x => x.Start.Month == start.Month);
        }

        public Turn UpdateTurn(int id, Turn turn)
        {
            var temp = _context.Turns.Find(u => u.Id == id);
            temp.Id = turn.Id;
            temp.Start= turn.Start;
            temp.Cust= turn.Cust;
            temp.Official= turn.Official;
            return temp;
        }
    }
}
