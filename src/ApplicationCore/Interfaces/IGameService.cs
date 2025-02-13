﻿using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IGameService
    {
        Task<Game> GetGameByIdAsync(int gameId);
        Task<Game> GetGameByIdWithGenresAsync(int gameId);
        Task<List<Game>> GetAllGamesAsync();
        Task<Game> AddGameAsync(Game game);
        Task UpdateGameAsync(Game game, string newGameName);
        Task<string> DeleteGameAsync(int gameId);
        Task<bool> CheckExistingGameithSameNameBeforeAdd(string gameName);
        Task<bool> CheckExistingGameWithSameNameBeforeUpdate(int gameId, string newGameName);
    }
}