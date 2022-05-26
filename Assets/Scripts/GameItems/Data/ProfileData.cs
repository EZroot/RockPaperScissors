using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProfileData 
{
    [SerializeField]
    int _id;
    [SerializeField]
    string _name;
    [SerializeField]
    int _coins;
    [SerializeField]
    int _betAmount;

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public int Coins { get => _coins; set => _coins = value; }
    public int BetAmount { get => _betAmount; set => _betAmount = value; }

    public ProfileData(int id, string name, int coins, int betAmount)
    {
        _id = id;
        _name = name;
        _coins = coins;
        _betAmount = betAmount;
    }

    public ProfileData(ProfileData data)
    {

        _id = data.Id;
        _name = data.Name;
        _coins = data.Coins;
        _betAmount = data.BetAmount;
    }
}
