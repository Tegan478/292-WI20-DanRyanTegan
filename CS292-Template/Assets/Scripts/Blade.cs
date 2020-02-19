using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blade : MonoBehaviour
{
	public GameObject bladeTrailPrefab;
	public Text endGameScore;
	public float minCuttingVelocity = .001f;
	public Text score;

	public static float count = 0;

	bool isCutting = false;

	Vector2 previousPosition;

	GameObject currentBladeTrail;

	Rigidbody2D rb;
	Camera cam;
	CircleCollider2D circleCollider;

	float itemVal;

	public static int chip = 0;
	public static int coffee = 0;
	public static int soda = 0;
	public static int cookie = 0;
	public static int eggs = 0;
	public static int noodle = 0;
	public static int popsicle = 0;
	public static int sandwich = 0;

	void Start()
	{
		cam = Camera.main;
		rb = GetComponent<Rigidbody2D>();
		circleCollider = GetComponent<CircleCollider2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			StartCutting();
		}
		else if (Input.GetMouseButtonUp(0))
		{
			StopCutting();
		}

		if (isCutting)
		{
			UpdateCut();
		}

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Chip") || col.CompareTag("Coffee") || col.CompareTag("Soda") || col.CompareTag("Cookie") || 
			col.CompareTag("Eggs") || col.CompareTag("Noodle") || col.CompareTag("Popsicle") || col.CompareTag("Sandwich"))
		{
			itemVal = Food.val;
			count += itemVal; //potentially col.value?
			endGameScore.text = count.ToString();
			score.text = count.ToString();

			if (col.CompareTag("Chip"))
			{
				chip++;
			} else if (col.CompareTag("Coffee"))
			{
				coffee++;
			} else if (col.CompareTag("Soda"))
			{
				soda++;
			} else if (col.CompareTag("Cookie"))
			{
				cookie++;
			} else if (col.CompareTag("Eggs"))
			{
				eggs++;
			} else if (col.CompareTag("Noodle"))
			{
				noodle++;
			} else if (col.CompareTag("Popsicle"))
			{
				popsicle++;
			} else if (col.CompareTag("Sandwich"))
			{
				sandwich++;
			}
			Destroy(col.gameObject);
		}
	}

	void UpdateCut()
	{
		Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
		rb.position = newPosition;

		float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
		if (velocity > minCuttingVelocity)
		{
			circleCollider.enabled = true;
		}
		else
		{
			circleCollider.enabled = false;
		}

		previousPosition = newPosition;
	}

	void StartCutting()
	{
		isCutting = true;
		currentBladeTrail = Instantiate(bladeTrailPrefab, transform);
		previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
		circleCollider.enabled = false;
	}

	void StopCutting()
	{
		isCutting = false;
		currentBladeTrail.transform.SetParent(null);
		Destroy(currentBladeTrail, 2f);
		circleCollider.enabled = false;
	}
}