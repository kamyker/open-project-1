using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class contains the function to call when play button is pressed
/// </summary>

public class StartGame : MonoBehaviourWithEvents<StartGame>
{
	// public LoadEventChannelSO onPlayButtonPress;
	public GameSceneSO[] locationsToLoad;
	public bool showLoadScreen;

	public EventChannel<GameSceneSO[], bool> OnPlayButtonPress;

	void Awake()
	{
		GetComponent<Button>().onClick.AddListener(() => OnPlayButtonPress.Invoke(locationsToLoad, showLoadScreen));
	}
}
