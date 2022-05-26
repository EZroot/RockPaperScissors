using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour
{
    public static GlobalData Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    [SerializeField]
    ProfileDataConfig _mockPlayerProfile;
    public ProfileDataConfig MockPlayerProfile { get => _mockPlayerProfile; }

    [SerializeField]
    ProfileDataConfig _mockOpponentProfile;
    public ProfileDataConfig MockOpponentProfile { get => _mockOpponentProfile; }

    [SerializeField]
    GameUpdateDataConfig _mockGameUpdateProfile;
    public GameUpdateDataConfig MockGameUpdateProfile { get => _mockGameUpdateProfile; }

    [SerializeField]
    bool _saveGame = false;
    public bool SaveGame { get => _saveGame; set => _saveGame = value; }

    bool _transferWins = false;
    public bool TransferWins { get => _transferWins; set => _transferWins = value; }
}
