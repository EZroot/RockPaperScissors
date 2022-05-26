using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferWinsCondition : StateCondition<GameStateMachine>
{
    GameData _gameData;

    void Awake()
    {
        _gameData = Object.FindObjectOfType<GameData>();
    }

    public override bool OnCondition(State<GameStateMachine> curr, State<GameStateMachine> next)
    {
        return GlobalData.Instance.TransferWins;
    }
}
