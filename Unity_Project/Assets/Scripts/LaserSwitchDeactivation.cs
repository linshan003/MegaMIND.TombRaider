using UnityEngine;
using System.Collections;

public class LaserSwitchDeactivation : MonoBehaviour 
{
	public GameObject laser ;
	public Material unlockedMat;

	private GameObject player;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag (Tags.player);
	}

	void OnTriggerStay(GameObject other)
	{
		if(other.gameObject == player)
		{
			if(Input.GetButton("Switch"))
			{

			}
		}
	}

	void LaserDeactivation()
	{
		// Deactivate the laser GameObject.
		laser.SetActive(false);
		
		// Store the renderer component of the screen.
		Renderer screen = transform.Find("prop_switchUnit_screen_001").renderer;
		
		// Change the material of the screen to the unlocked material.
		screen.material = unlockedMat;
		
		// Play switch deactivation audio clip.
		audio.Play();

	}
}
