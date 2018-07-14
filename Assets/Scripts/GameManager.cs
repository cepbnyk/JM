using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class GameManager : MonoBehaviour
{
	private bool _roll;

	private bool _faceCounted;
	// Update is called once per frame
	public DiceScript[] Dice;
	private int _jhanda = 0, _burja =0, _itta = 0, _paan = 0, _hukum = 0, _chiddi = 0;

	/*private class Diceinfo
	{
		private int _diceCount;

	}*/
	
	public bool RollBool
	{
		get { return _roll; }
		set
		{
			/*for (int i = 0; i < 6; i++)
			{
				Dice[i].Reset();
				//Dice[i].HasValue = false;
			}*/
			if (!_roll)
				value = true;
			else
				value = false;
			_roll = value;
			_faceCounted = false;
			Debug.Log(_roll);
		}
	}

	public void ResetDice()
	{
		_roll = false;
		for (int i = 0; i < 6; i++)
		{
			Dice[i].Reset();
			Dice[i].DiceValue = 0;
			Dice[i].HasValue = false;
			_jhanda = 0;
			_burja = 0;
			_itta = 0;
			_paan = 0;
			_hukum = 0;
			_chiddi = 0;
		}
	}
	

	private void Update()
	{
		if (!_faceCounted)
		{
			if (Dice[0].HasValue && Dice[1].HasValue && Dice[2].HasValue && Dice[3].HasValue && Dice[4].HasValue &&
			    Dice[5].HasValue)
			{
				FaceCount();
			}
		}
		
	}
	
	//kun gotti ma k paryo 

	void FaceCount()
	{
		for (int i = 0; i < 6; i++)
		{
			switch (Dice[i].DiceValue)
			{
				case 1:
					_jhanda++;
				//	_jhanda.Add(Dice[i].DiceValue);
					break;
				case 2:
					_burja++;
				//	_burja.Add(Dice[i].DiceValue);
					break;
				case 3:
					_itta++;
				//	_itta.Add(Dice[i].DiceValue);
					break;
				case 4:
					_hukum++;
				//	_hukum.Add(Dice[i].DiceValue);
					break;
				case 5 :
					_paan++;
				//	_paan.Add(Dice[i].DiceValue);
					break;
				case 6:
					_chiddi++;
				//	_chiddi.Add(Dice[i].DiceValue);
					break;
			}
		}

		_faceCounted = true;
		Debug.Log("Burja" + _burja);
		Debug.Log("Jhanda" + _jhanda);
		Debug.Log("Itta" + _itta);
		Debug.Log("Hukum" + _hukum);
		Debug.Log("Paan" + _paan);
		Debug.Log("Chiddi" + _chiddi);

	}
}
