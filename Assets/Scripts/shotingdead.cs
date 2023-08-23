using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotingdead : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{

		if (other.name.Contains("Player"))
		{

			var player = other.GetComponent<Player>();

			Destroy(gameObject);
			player.Dead();
		}
	}
}
