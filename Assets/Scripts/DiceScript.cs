using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class DiceScript : MonoBehaviour
{
	private Rigidbody _rb;
	private bool _haslanded, _thrown;
	private Vector3 _initPos;
	public GameManager Gm;
	public bool HasValue;

	public int DiceValue =0;

	private void Start()
	{
		_rb = GetComponent<Rigidbody>();
		_initPos = new Vector3(Random.Range(-20,20), 35, Random.Range(-15,15));
		_rb.useGravity = false;
	}

	private void Update()
	{
		if (Gm.RollBool)
		{
			if (!_thrown && !_haslanded)
			{
				_thrown = true;
				_rb.useGravity = true;
				_rb.AddTorque(Random.Range(0,5),Random.Range(0,5),Random.Range(0,5));
			}
			else if (_thrown && _haslanded)
			{
				HasValue = true;
			}
			
		}

		if (_rb.IsSleeping() && !_haslanded && _thrown)
		{
			_haslanded = true;
			_rb.useGravity = false;
		}
		/*else if (_rb.IsSleeping() && _haslanded && DiceValue == 0)
		{
			RollAgain();
			Debug.Log("RollAgain");
		}*/
	}

	public void Reset()
	{
		transform.position = _initPos;
		_thrown = false;
		_haslanded = false;
		_rb.useGravity = false;
		//Gm.RollBool = false; //yo chai roll off garne paxi antai change hunxa hai 
	}
	
	void RollAgain()
	{
		Reset();
		_thrown = true;
		_rb.useGravity = true;
		_rb.AddTorque(Random.Range(0,5),Random.Range(0,5),Random.Range(0,5));
	}
}
