using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    [SerializeField]
    public Text _playerHandText;
    public Text PlayerHandText { get => _playerHandText; }

    [SerializeField]
    public Text _enemyHandText;

    public Text EnemyHandText { get => _enemyHandText; }

    [SerializeField]
    private Text _nameLabel;
    [SerializeField]
    private Text _moneyLabel;

    public void UpdateHud(ProfileData playerProfile)
    {
        _nameLabel.text = "Name: " + playerProfile.Name;
        _moneyLabel.text = "Money: $" +  playerProfile.Coins;
    }

    public void UpdateHudHands(GameUpdateData gameUpdateData)
    {
        _playerHandText.text = DisplayResultAsText(gameUpdateData.PlayerChoice);
        _enemyHandText.text = DisplayResultAsText(gameUpdateData.OpponentChoice);
    }

    string DisplayResultAsText(UseableItemSelection result)
    {
        switch (result)
        {
            case UseableItemSelection.Rock:
                return "Rock";
            case UseableItemSelection.Paper:
                return "Paper";
            case UseableItemSelection.Scissors:
                return "Scissors";
        }

        return "Nothing";
    }
}
