using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameUpdateData
{
    [SerializeField]
    UseableItemSelection _playerChoice;
    [SerializeField]
    UseableItemSelection _opponentChoice;
    [SerializeField]
    int _playerCoinsAmountChanged;
    [SerializeField]
    int _opponentCoinsAmountChanged;
    public UseableItemSelection PlayerChoice { get => _playerChoice; set => _playerChoice = value; }
    public UseableItemSelection OpponentChoice { get => _opponentChoice; set => _opponentChoice = value; }
    public int PlayerCoinsAmountChanged { get => _playerCoinsAmountChanged; set => _playerCoinsAmountChanged = value; }
    public int OpponentCoinsAmountChanged { get => _opponentCoinsAmountChanged; set => _opponentCoinsAmountChanged = value; }

    public GameUpdateData(UseableItemSelection playerChoice,
        UseableItemSelection opponentChoice,
        int playerCoinsAmountChanged,
        int opponentCoinsAmountChanged)
    {
        _playerChoice = playerChoice;
        _opponentChoice = opponentChoice;
        _playerCoinsAmountChanged = playerCoinsAmountChanged;
        _opponentCoinsAmountChanged = opponentCoinsAmountChanged;
    }
    public GameUpdateData(GameUpdateData data)
    {
        _playerChoice = data.PlayerChoice;
        _opponentChoice = data.OpponentChoice;
        _playerCoinsAmountChanged = data.PlayerCoinsAmountChanged;
        _opponentCoinsAmountChanged = data.OpponentCoinsAmountChanged;
    }
}
