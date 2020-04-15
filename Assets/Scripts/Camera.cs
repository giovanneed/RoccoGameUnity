using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{


	public float distance = 2f;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    public void Hello(){
    	Debug.Log("hello camera");
    	distance = 2f;

    }

    // Update is called once per frame
    void Update()
    {	
    	distance = distance  + 0.04f;

    	transform.position = new Vector3(distance, 1,-10);  
        
    }
}
