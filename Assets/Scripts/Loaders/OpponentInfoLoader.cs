using UnityEngine;
using System.Collections;
using System;

public class OpponentInfoLoader : BaseLoader<ProfileData>
{
	public Action<ProfileData> OnLoaded;

	public override void Load()
	{
		OnLoaded(SaveUtility.LoadOpponent());
	}

	public override void LoadFake(ProfileData data)
	{
		OnLoaded(data);
	}
}