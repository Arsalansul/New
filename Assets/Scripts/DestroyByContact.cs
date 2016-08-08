using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameControlle gameController;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null )
		{
			gameController = gameControllerObject.GetComponent <GameControlle>();
		}
		if (gameControllerObject == null) 
		{
			Debug.Log ("Can not find Game Controller");
		}
	}

	void OnTriggerEnter (Collider other)
	{	

		if (other.tag == "Boundary")
			return;
		Destroy (other.gameObject);
		Destroy (gameObject);

		if (other.tag == "Player") 
		{
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver ();
		}
		
		Instantiate(explosion, transform.position, transform.rotation);

		gameController.AddScore (scoreValue);
	}

}
