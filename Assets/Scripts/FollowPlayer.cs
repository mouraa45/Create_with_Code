using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{	//public GameObject player;
	public GameObject cam1;
	public GameObject cam2;
    //private Vector3 offset = new Vector3(0,5,-7);
    //private Vector3 offset1 = new Vector3(0,8,-3);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    
    
    void LateUpdate()
    {		
    	if (Input.GetKeyDown("1")){
    			//transform.position = cam1.transform.position + offset;
    			//transform.position= cam2.transform.position+ offset1;
    			cam1.SetActive(false);
    			cam2.SetActive(true);
    	}
    	if (Input.GetKeyDown("2"))
    	{
    		cam1.SetActive(true);
    		cam2.SetActive(false);
    	}
    	}
}
