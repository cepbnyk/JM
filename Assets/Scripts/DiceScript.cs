using UnityEngine;

public class DiceScript : MonoBehaviour
{
	public static DiceScript Instance { get; set; }

	public static DiceScript GetInstance()
	{
		if (Instance == null)
		{
			return FindObjectOfType<DiceScript>();
		}

		return Instance;
	}
	public float forceAmount = 20f;
	public float torqueAmount = 50f;
	public bool roll;
	public ForceMode forceMode;
	private Transform[] _dice;
	private float nextRoll;
	private float RollRate = .5f;

	private void Start()
	{
		_dice = GetComponentsInChildren<Transform>();
		for (int i = 0; i < _dice.Length; i++)
		{
			Debug.Log(_dice[i].transform.position);
		}
		
	}

	public void Roll()
	{
		if (roll)
			roll = false;
		else
			roll = true;
		
		
	}

	private void Update()
	{
		if (roll && Time.time>nextRoll)
		{
			nextRoll = Time.time + RollRate;
			Debug.Log("Rolled");
			for (int i = 0; i < 6; i++)
			{
				transform.GetChild(i).GetComponent<Rigidbody>().AddForce(Random.onUnitSphere*forceAmount, forceMode);
				transform.GetChild(i).GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere*torqueAmount,forceMode);
			
			}
		}
		
	}
}

