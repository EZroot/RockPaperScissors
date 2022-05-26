using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{

    Player _player;
    public Player Player { get => _player; set => _player = value; }

    Opponent _opponent;
    public Opponent Opponent { get => _opponent; set => _opponent = value; }

    GameUpdateData _gameUpdateData;
    public GameUpdateData GameUpdateData { get => _gameUpdateData; set => _gameUpdateData = value; }
}
