using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameUpdateDataConfig : ScriptableObject
{
    [SerializeField]
    GameUpdateData _gameResultData = null;
    public GameUpdateData ProfileData
    {
        get { return _gameResultData; }
        set { _gameResultData = value; }
    }
}
