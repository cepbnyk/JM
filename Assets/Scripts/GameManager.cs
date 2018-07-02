using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	
	public static GameManager Instance { get; set; }

	public static GameManager GetInstance()
	{
		if (Instance == null)
		{
			return FindObjectOfType<GameManager>();
		}

		return Instance;
	}


	//public bool Roll;

	
	public void RollDices()
	{
		GameObject.FindGameObjectWithTag("Dice").GetComponentInChildren<DiceScript>().Roll();
	}
}
