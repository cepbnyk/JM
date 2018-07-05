using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class GameManager : MonoBehaviour
{
	private bool _roll;
	
	// Update is called once per frame
	public DiceScript[] Dice;

	
	public bool RollBool
	{
		get { return _roll; }
		set
		{
			if (!_roll)
				value = true;
			else
				value = false;
			_roll = value;
			Debug.Log(_roll);
		}
	}

	private void Update()
	{
		if (Dice[0].HasValue && Dice[1].HasValue && Dice[2].HasValue && Dice[3].HasValue && Dice[4].HasValue &&
		    Dice[5].HasValue)
		{
			for (int i = 0; i < 6; i++)
			{
				Dice[i].Reset();
				Dice[i].HasValue = false;
			}
			
			RollBool = false;
		}
	}
}
