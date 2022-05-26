using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UpdateGameInfoLoader : BaseLoader<GameUpdateData>
{
	public Action<GameUpdateData> OnLoaded;
	public override void Load()
	{
		OnLoaded(SaveUtility.LoadGameData());
	}

	public override void LoadFake(GameUpdateData data)
	{
		OnLoaded(data);
	}
}
