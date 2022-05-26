using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerBehaviour
{
	ProfileData _data;
	public ProfileData ProfileData {get=>_data;}

	UseableItemSelection _currentHand = UseableItemSelection.None;
	public UseableItemSelection CurrentHand {get=>_currentHand;set=>_currentHand=value;}

	public PlayerBehaviour(ProfileData profile)
	{
		this._data = profile;
	}
	
	public int GetUserId()
	{
		return this._data.Id;
	}
	
	public string GetName()
	{
		return this._data.Name;
	}

	public int GetCoins()
	{
		return this._data.Coins;
	}

	public void ChangeCoinAmount(int amount)
	{
		this._data.Coins += amount;
	}
}
