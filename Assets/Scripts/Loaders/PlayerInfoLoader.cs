using UnityEngine;
using System.Collections;
using System;

public class PlayerInfoLoader : BaseLoader<ProfileData>
{
	public Action<ProfileData> OnLoaded;

	public override void Load()
	{
		OnLoaded(SaveUtility.LoadPlayer());
	}

	public override void LoadFake(ProfileData data)
	{
		OnLoaded(data);
	}
}