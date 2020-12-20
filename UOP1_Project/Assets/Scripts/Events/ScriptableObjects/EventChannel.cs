using System;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// This class is a used for scene loading events.
/// Takes an array of the scenes we want to load and a bool to specify if we want to show a loading screen.
/// </summary>
// [CreateAssetMenu(menuName = "Events/Load Event Channel")]
// public class LoadEventChannelSO : EventChannelBaseSO
// {
// 	public UnityAction<GameSceneSO[], bool> OnLoadingRequested;
//
// 	public void RaiseEvent(GameSceneSO[] locationsToLoad, bool showLoadingScreen)
// 	{
// 		if (OnLoadingRequested != null)
// 		{
// 			OnLoadingRequested.Invoke(locationsToLoad, showLoadingScreen);
// 		}
// 		else
// 		{
// 			Debug.LogWarning("A Scene loading was requested, but nobody picked it up." +
// 				"Check why there is no SceneLoader already present, " +
// 				"and make sure it's listening on this Load Event channel.");
// 		}
// 	}
// }

public struct EventChannel<T1, T2>
{
	public Action<T1, T2> OnRaised;

	public void Invoke(T1 t1, T2 t2)
	{
		if (OnRaised != null)
		{
			OnRaised.Invoke(t1, t2);
		}
		else
		{
			Debug.LogWarning("EventChannel was requested, but nobody picked it up." +
							 "Check why noone is listening to this channel, " +
							 "and make sure it's listening on this OnRaised event.");
		}
	}

	public void AddListener(Action<T1, T2> action)
	{
		OnRaised += action;
	}

	public void RemoveListener(Action<T1, T2> action)
	{
		OnRaised -= action;
	}
}
