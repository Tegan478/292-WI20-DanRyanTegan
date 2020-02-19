using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
	public GameObject slicedPrefab;
	private float minForce = 17f;
	private float maxForce = 17f;
	private float randomForce;
	public float indval;

	public static float val;

	Rigidbody2D rb;
	public AudioSource source;

	void Start()
	{
		source = GetComponent<AudioSource>();
		randomForce = Random.Range(minForce, maxForce);
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * randomForce, ForceMode2D.Impulse);
		rb.AddTorque(Random.Range(-180,180));
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Blade"))
		{
			source.Play();
			val = indval;
			Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);

			GameObject slicedFruit = Instantiate(slicedPrefab, transform.position, rotation);
			Destroy(slicedFruit, 3f);
		}
	}
}
