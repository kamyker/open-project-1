using System;
using UnityEngine;

public class MonoBehaviourWithEvents<T> : MonoBehaviour where T : MonoBehaviourWithEvents<T>
{
	public static event Action<T> Enabled;
	public static event Action<T> Disabled;

	protected virtual void OnEnable()
	{
		Enabled?.Invoke((T)this);
	}

	protected virtual void OnDisable()
	{
		Disabled?.Invoke((T)this);
	}
}
