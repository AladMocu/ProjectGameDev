using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour {

	public GameObject topBack;
	public GameObject botomback;
	private float verticalSize;
	private int current = 0;
	// Use this for initialization
	void Start () {
		float y_size = topBack.GetComponent<BoxCollider2D> ().size.y;
		verticalSize = 2 * y_size;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == "Background") {
			RepositionB ();
		}
	}

	public void RepositionB()
	{
		if (current == 0) {
			botomback.transform.position = new Vector2 (botomback.transform.position.x,
				botomback.transform.position.y + verticalSize);
			current = 1;
		}
		else if (current == 1) {
			topBack.transform.position = new Vector2 (topBack.transform.position.x,
				topBack.transform.position.y + verticalSize);
			current = 0;
		}
		}

}
