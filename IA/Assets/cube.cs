using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {
	int index=0;
	float t=0;
	int[] path = new int[] {0,1,2,3,4};
	List<Vector3> points = new List<Vector3>();
	void Start () 
	{
		points.Add(GameObject.Find("P1").transform.position);
		points.Add(GameObject.Find("P2").transform.position);
		points.Add(GameObject.Find("P3").transform.position);
		points.Add(GameObject.Find("P4").transform.position);
		points.Add(GameObject.Find("P5").transform.position);
		points.Add(GameObject.Find("P6").transform.position);
	}
	
	// Update is called once per frame
	void Update () {
			t += 0.02f;
		transform.position = Vector3.Lerp (points [path[index]], points [path[index+1]], t);
		if (t >= 1) 
		{
			index++;
			t = 0;
		}
		if (index == path.Length-1) {
			index = 0;
			getPath ();
		}	
	}

	public void getPath()

	{
		int a, b, c,d;

		a=Random.Range (0, 6);
		b=Random.Range (0, 6);
		c=Random.Range (0, 6);
		d=Random.Range (0, 6);
		
		while (a == b || a == c || a == d) 
		{
			a = Random.Range (0, 6);
		}
		while (b == a|| b == c || b == d)
		{
			b = Random.Range (0, 6);
		}
		while (c == b|| c== a|| c == d)
		{	
			c = Random.Range (0, 6);
		}
		while (d == c || d == b || d == a)
		{
			d = Random.Range (0, 6);
		}
		path= new int[]{a,b,c,d};

		Debug.Log (a);
		Debug.Log (b);
		Debug.Log (c);
		Debug.Log (d);
	}
}
