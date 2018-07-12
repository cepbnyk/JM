using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class DiceScript : MonoBehaviour
{
	private Rigidbody _rb;
	private bool _haslanded, _thrown;
	//private Vector3 _initPos;
	public GameManager Gm;
	public bool HasValue;
	public ForceMode fm;

	public int DiceValue =0;

	private void Start()
	{
		_rb = GetComponent<Rigidbody>();
		transform.position = new Vector3(Random.Range(-18,18), 35, Random.Range(-8,8));
		_rb.useGravity = false;
		_rb.isKinematic = true;
	}

	private void Update()
	{
		if (Gm.RollBool)
		{
			if (!_thrown && !_haslanded)
			{
				_thrown = true;
				_rb.useGravity = true;
				_rb.isKinematic = false;
				_rb.AddForce(Vector3.down*20,fm);
				_rb.AddTorque(Random.onUnitSphere*50, fm);
				//_rb.AddTorque(Random.Range(0,5),Random.Range(0,5),Random.Range(0,5));
			}
			else if (_thrown && _haslanded)
			{
				HasValue = true;
			}
			
		}

		if (_rb.IsSleeping() && !_haslanded && _thrown)
		{
			_haslanded = true;
			
		//	_rb.useGravity = false;
		}
		/*else if (_rb.IsSleeping() && _haslanded && DiceValue == 0)
		{
			RollAgain();
			Debug.Log("RollAgain");
		}*/
	}

	public void Reset()
	{
		transform.position = new Vector3(Random.Range(-18,18), 35, Random.Range(-8,8));
		
		_rb.useGravity = false;
		_rb.isKinematic = true;
		_thrown = false;
		_haslanded = false;
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
