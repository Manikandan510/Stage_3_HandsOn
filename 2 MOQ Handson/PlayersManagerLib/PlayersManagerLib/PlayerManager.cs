﻿namespace PlayersManagerLib
{
    public interface IPlayerMapper

    {

        bool IsPlayerNameExistsInDb(string name);

        void AddNewPlayerIntoDb(string name);

    }
    public class PlayerManager
    {
    }
}
