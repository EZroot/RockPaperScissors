using UnityEngine;
using System.Collections;

public enum Result
{
	Won,
	Lost,
	Draw
}

public class ResultAnalyzer
{
	public static Result GetResultState(UseableItemSelection playerHand, UseableItemSelection enemyHand)
	{
		if (isStronger(playerHand, enemyHand))
		{
			return Result.Won;
		}
		else if (isStronger(enemyHand, playerHand))
		{
			return Result.Lost;
		}
		else
		{
			return Result.Draw;
		}
	}

	private static bool isStronger (UseableItemSelection firstHand, UseableItemSelection secondHand)
	{
		switch (firstHand)
		{
			case UseableItemSelection.Rock:
			{
				switch (secondHand)
				{
					case UseableItemSelection.Scissors:
						return true;
					case UseableItemSelection.Paper:
						return false;
				}
				break;
			}
			case UseableItemSelection.Paper:
			{
				switch (secondHand)
				{
					case UseableItemSelection.Rock:
						return true;
					case UseableItemSelection.Scissors:
						return false;
				}
				break;
			}
			case UseableItemSelection.Scissors:
			{
				switch (secondHand)
				{
					case UseableItemSelection.Paper:
						return true;
					case UseableItemSelection.Rock:
						return false;
				}
				break;
			}
		}

		return false;
	}
}