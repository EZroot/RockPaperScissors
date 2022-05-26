using UnityEngine;
using System.Collections;
using System;

public class Player : PlayerBehaviour
{
	public Player(ProfileData data) : base(data)
	{
		
	}

	public UseableItemSelection GetHand(int item)
    {
        UseableItemSelection playerChoice = UseableItemSelection.None;

        switch (item)
        {
            case 1:
                playerChoice = UseableItemSelection.Rock;
                break;
            case 2:
                playerChoice = UseableItemSelection.Paper;
                break;
            case 3:
                playerChoice = UseableItemSelection.Scissors;
                break;
        }

        return playerChoice;
    }
}