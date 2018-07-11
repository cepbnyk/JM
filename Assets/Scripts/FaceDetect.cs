using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceDetect : MonoBehaviour {
	private void OnTriggerStay(Collider other)
	{
		if (other.gameObject.CompareTag("Jhanda"))
		{
			if (other.transform.parent.GetComponent<Rigidbody>().IsSleeping())
			{
				other.transform.parent.GetComponent<DiceScript>().DiceValue = 2;
			}
		}
		else if (other.gameObject.CompareTag("Burja"))
		{
			if (other.transform.parent.GetComponent<Rigidbody>().IsSleeping())
			{
				other.transform.parent.GetComponent<DiceScript>().DiceValue = 1;
			}
		}
		else if (other.gameObject.CompareTag("Itta"))
		{
			if (other.transform.parent.GetComponent<Rigidbody>().IsSleeping())
			{
				other.transform.parent.GetComponent<DiceScript>().DiceValue = 4;
			}
		}
		else if (other.gameObject.CompareTag("Hukum"))
		{
			if (other.transform.parent.GetComponent<Rigidbody>().IsSleeping())
			{
				other.transform.parent.GetComponent<DiceScript>().DiceValue = 3;
			}
		}
		else if (other.gameObject.CompareTag("Paan"))
		{
			if (other.transform.parent.GetComponent<Rigidbody>().IsSleeping())
			{
				other.transform.parent.GetComponent<DiceScript>().DiceValue = 6;
			}
		}
		else if (other.gameObject.CompareTag("Chiddi"))
		{
			if (other.transform.parent.GetComponent<Rigidbody>().IsSleeping())
			{
				other.transform.parent.GetComponent<DiceScript>().DiceValue = 5;
			}
		}
	}
}
