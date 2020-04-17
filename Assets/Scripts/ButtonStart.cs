using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void loadGame(){
   	UnityEngine.Debug.Log("load Game");
	UnityEngine.SceneManagement.SceneManager.LoadScene("Scene");
   }
}
