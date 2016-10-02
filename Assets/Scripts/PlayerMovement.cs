using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5;
    public int direction = 0;

    // 


	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = 1;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = 2;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = 3;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = 4;
        }


        //Up
        if (direction == 1)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }

        //Down
        if (direction == 2)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }

        //Right
        if (direction == 3)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        //Left
        if (direction == 4)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }


        RaycastHit hit;
        Ray upRay = new Ray(transform.position, Vector3.up);

        if (Physics.Raycast(upRay, out hit, 0.51f))
        {
            if(hit.collider.tag == "Wall")
            {
                direction = 0;
            }
        }
        Debug.DrawRay(upRay.origin, upRay.direction * 1.0f, Color.white);
    }
}