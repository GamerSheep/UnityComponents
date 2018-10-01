using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
    public SpriteRenderer rend;
    public Color color; 
    public float movespeed;
    public float rotationspeed;
    public TrailRenderer trail;


	// Use this for initialization
	void Start () {
        rend.color = new Color(0,2f, 0.25f, 0.33f);
        //transform.position = new Vector3(-5f, transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
        //1 / fps

        if (Input.GetKey(KeyCode.LeftArrow)) {
        transform.Rotate(0, 0, rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(movespeed * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.green;
            trail.startColor = Color.green;
            trail.endColor = Color.blue;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-movespeed / 2 * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.red;
            trail.endColor = new Color(1, 0, 1);
            trail.startColor = new Color(1, 0.5f, 0);
        }


    }
}
