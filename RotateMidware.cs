using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMidware : MonoBehaviour 
{

	private float offset = .1f;
	private Quaternion rotateOffset = Quaternion.Euler(0, 0, 0.5f);
	private Quaternion offsetRoatation;
	private Quaternion targetRoatation;
	// private Camera m_camera;
	public GameObject rotateObj;
	public GameObject test1;
	// Use this for initialization
	private void Awake() 
	{
		// m_camera = Camera.main;
	}
	void Start() 
	{	
		offsetRoatation = rotateObj.transform.rotation;
	}
	
	// Update is called once per frame
	void Update() 
	{
		Vector3 lookPosition;
		Plane plane = new Plane(Vector3.up, rotateObj.transform.position);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float distanceToPlane;
		if (plane.Raycast(ray, out distanceToPlane))
		{
			lookPosition = ray.GetPoint(distanceToPlane);
			Quaternion rotation = Quaternion.LookRotation(lookPosition - rotateObj.transform.position);
			float rotationEuler = Mathf.Floor(rotation.eulerAngles.y);
			float offsetEuler = Mathf.Floor(offsetRoatation.eulerAngles.y);
			// Debug.Log(Quaternion.LookRotation(lookPosition - rotateObj.transform.position));
			Debug.Log(rotationEuler + ", " + offsetEuler);
			if (rotationEuler != offsetEuler)
			{
				
			}
			rotateObj.transform.rotation = offsetRoatation;
		}
	}

	private int Quadrant(float x)
	{
		int result = 0;
		if (x >= 0 && x < 90)
		{
			result = 1;
		}
		else if (x > 90 && x < 180)
		{
			result = 2;
		}
		else if (x > 90 && x < 270)
		{
			result = 3;
		}
		else if (x > 270 && x < 360)
		{
			result = 4;
		}
		return result;
	}

	private void DeterminedRotate(int quadrant1, int quadrant2)
	{

	}

	void FixedUpdate()
	{
		
	}

	void Rotation()
	{
		
	}
}
