﻿public class GameFlow
{
    public static GameState State;
}

public enum GameState
{
    WaitingForTest, RecreateServer, WaitingForChallenge, ReadyToConnect, Connecting, Gameplay, Won, Lost
}
