using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public int sensitivity;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 newForce;
        newForce.x = newForce.y = 0;
        if (Input.GetKeyDown("down"))
        {
            newForce.y = -sensitivity;
        }
        else if (Input.GetKeyDown("up"))
        {
            newForce.y = sensitivity;
        }
        else if (Input.GetKeyDown("left"))
        {
            newForce.x = -sensitivity;
        }
        else if (Input.GetKeyDown("right"))
        {
            newForce.x = sensitivity;
        }
        GetComponent<Rigidbody2D>().AddForce(newForce);
    }
}
