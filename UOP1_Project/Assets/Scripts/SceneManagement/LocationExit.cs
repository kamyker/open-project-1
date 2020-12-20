using UnityEngine;

/// <summary>
/// This class goes on a trigger which, when entered, sends the player to another Location
/// </summary>

public class LocationExit : MonoBehaviourWithEvents<LocationExit>
{
	[Header("Loading settings")]
	[SerializeField] private GameSceneSO[] _locationsToLoad = default;
	[SerializeField] private bool _showLoadScreen = default;

	public EventChannel<GameSceneSO[], bool> Entered;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Entered.Invoke(_locationsToLoad, _showLoadScreen);
		}
	}
}
