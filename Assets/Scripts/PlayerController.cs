using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public string inputID;
	private float horizontalInput;
	private float forwardInput;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float  speed =20;
    private float turnSpeed=45;
    	
    void Update()
    {
    	horizontalInput= Input.GetAxis("Horizontal"+inputID);
    	forwardInput =Input.GetAxis("Vertical"+inputID);
        // Move the veicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed*forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed* horizontalInput);
    }
}
