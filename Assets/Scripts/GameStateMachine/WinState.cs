using UnityEngine;

public class WinState : State<GameStateMachine>
{
    public GameController GameController { get => (GameController)BaseFeature; }

    public override void OnEnter()
    {
        GameUpdateData gameData = GameController.GameData.GameUpdateData;
        Player player = GameController.GameData.Player;
        Opponent opponent = GameController.GameData.Opponent;

        //update game data results
        gameData.PlayerChoice = player.CurrentHand;
        gameData.OpponentChoice = opponent.CurrentHand;
        gameData.PlayerCoinsAmountChanged = GetCoinsAmount(player, opponent);
        gameData.OpponentCoinsAmountChanged = GetCoinsAmount(opponent, player);

        //update player/opponent details
        GameController.GameData.Player.ChangeCoinAmount(gameData.PlayerCoinsAmountChanged);
        GameController.GameData.Opponent.ChangeCoinAmount(gameData.OpponentCoinsAmountChanged);
        
        //save the game
        if (GlobalData.Instance.SaveGame)
        {
            SaveUtility.Save(player.ProfileData, opponent.ProfileData, gameData);
        }

        //finished this state
        GlobalData.Instance.TransferWins = false;
    }

    public override void OnExit()
    {
        //update huds
        GameController.View.UpdateHud(GameController.GameData.Player.ProfileData);
        GameController.View.UpdateHudHands(GameController.GameData.GameUpdateData);
    }

    private int GetCoinsAmount(PlayerBehaviour playerA, PlayerBehaviour playerB)
    {
        Result drawResult = ResultAnalyzer.GetResultState(playerA.CurrentHand, playerB.CurrentHand);

        if (drawResult.Equals(Result.Won))
        {
            return playerA.ProfileData.BetAmount;
        }
        else if (drawResult.Equals(Result.Lost))
        {
            return -playerA.ProfileData.BetAmount;
        }
        return 0;
    }
}
