using UnityEngine;
using System.Collections;

public class DestroyExplotions : MonoBehaviour 
{
	public float lifetime;
	void Start()
	{
		Destroy (gameObject, lifetime);
	}
}
