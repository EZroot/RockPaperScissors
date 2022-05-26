using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Opponent : PlayerBehaviour
{
	public Opponent(ProfileData data) : base(data)
	{
	}

    public UseableItemSelection GetHand()
    {
        return (UseableItemSelection)Enum.GetValues(typeof(UseableItemSelection)).GetValue(UnityEngine.Random.Range(1, 4));
    }
}
