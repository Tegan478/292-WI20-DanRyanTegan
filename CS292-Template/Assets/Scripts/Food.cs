using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
	public GameObject slicedPrefab;
	private float startForce = 17f;

	Rigidbody2D rb;

	public GameObject life1;
	public GameObject life2;
	public GameObject life3;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Blade"))
		{
			Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);

			GameObject slicedFruit = Instantiate(slicedPrefab, transform.position, rotation);
			Destroy(slicedFruit, 3f);
			Destroy(gameObject);
		}
		if (col.CompareTag("OffScreen"))
		{
			Destroy(gameObject);
			if (life3.activeSelf)
			{
				life3.SetActive(false);
			} else if (life2.activeSelf)
			{
				life2.SetActive(false);
			} else if (life2.activeSelf)
			{
				life1.SetActive(false);
			} else
			{
				print("Game Over");
			}
		}
	}
}
