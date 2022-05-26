using UnityEngine;

public class PlayingState : State<GameStateMachine>
{
    public GameController GameController { get => (GameController)BaseFeature; }

    public void OnPlayerChoiceClick(int item)
    {
        GameController.GameData.Player.CurrentHand = GameController.GameData.Player.GetHand(item);
        GameController.GameData.Opponent.CurrentHand = GameController.GameData.Opponent.GetHand();
        GlobalData.Instance.TransferWins = true;
    }
}
