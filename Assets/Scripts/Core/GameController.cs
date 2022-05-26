using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class GameController : BaseFeature
{
    public Action OnFeatureLoaded;
    public Action OnStartFeature;
    public Action OnStopFeature;

    [SerializeField]
    GameStateMachine _stateMachine;

    [SerializeField]
    GameView _gameView;
    public GameView View {get=>_gameView;}

    [SerializeField]
    GameData _gameData;
    public GameData GameData {get=>_gameData;}

    UpdateGameInfoLoader _gameInfoLoader;
    PlayerInfoLoader _playerInfoLoader;
    OpponentInfoLoader _opponentInfoLoader;

    void Awake()
    {
        _gameInfoLoader = new UpdateGameInfoLoader();
        _playerInfoLoader = new PlayerInfoLoader();
        _opponentInfoLoader = new OpponentInfoLoader();
        
        StopFeature();
    }

    void Start()
    {
        StartCoroutine(LoadFeature());
    }

    IEnumerator LoadFeature()
    {
        BootGame();
        yield return null;
        OnFeatureLoaded?.Invoke();
        StartFeature();
    }

    void BootGame()
    {
        _gameInfoLoader.OnLoaded += LoadGame;
        _gameInfoLoader.OnLoaded += UpdateHudHands;

        _playerInfoLoader.OnLoaded += LoadPlayer;
        _playerInfoLoader.OnLoaded += UpdateHud;

        _opponentInfoLoader.OnLoaded += LoadOpponent;

        if (GlobalData.Instance.SaveGame)
        {
            _gameInfoLoader.Load();
            _opponentInfoLoader.Load();
            _playerInfoLoader.Load();
        }
        else
        {
            _gameInfoLoader.LoadFake(GlobalData.Instance.MockGameUpdateProfile.ProfileData);
            _opponentInfoLoader.LoadFake(GlobalData.Instance.MockOpponentProfile.ProfileData);
            _playerInfoLoader.LoadFake(GlobalData.Instance.MockPlayerProfile.ProfileData);
        }
    }

    void LoadGame(GameUpdateData data)
    {
        _gameData.GameUpdateData = new GameUpdateData(data);
    }

    void LoadPlayer(ProfileData data)
    {
        _gameData.Player = new Player(new ProfileData(data));
    }

    void LoadOpponent(ProfileData data)
    {
        _gameData.Opponent = new Opponent(new ProfileData(data));
    }

    void UpdateHud(ProfileData data)
    {
        _gameView.UpdateHud(data);
    }

    void UpdateHudHands(GameUpdateData data)
    {
        _gameView.UpdateHudHands(data);
    }

    void StartFeature()
    {
        _stateMachine.gameObject.SetActive(true);
        _gameView.gameObject.SetActive(true);
        OnStartFeature?.Invoke();
    }

    void StopFeature()
    {
        _stateMachine.gameObject.SetActive(false);
        _gameView.gameObject.SetActive(false);

        OnStopFeature?.Invoke();
    }
}