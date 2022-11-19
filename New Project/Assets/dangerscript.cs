using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangerscript : MonoBehaviour
{
    // Start is called before the first frame update
    private int HPs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision col)
   
        
    {
                // Check for collision with Player
        if (col.gameObject.tag == "Player")
        {
            
            HPs = HPs - 1;
            

                    }
    }
}
