﻿using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface ITurnsServices
    {
        List<Turn> GetTurns();

        Turn GetByStart(DateTime start);

        void AddTurn(Turn turn);

        void UpdateTurn(int id, Turn turn);

        void DeleteTurn(int id);
    }
}
