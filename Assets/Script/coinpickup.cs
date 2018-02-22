using UnityEngine;
using System.Collections;

public class coinpickup : MonoBehaviour {

	public int pointstoadd;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.GetComponent<playermovement>() == null)
			return;

		ScoreManager.AddPoints (pointstoadd);

		Destroy (gameObject);
	}

}
