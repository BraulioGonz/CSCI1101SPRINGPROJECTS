using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }   
    
    void OnCollisiononEnter(Collision c)
    {
       if (Equals(c.GetComponent<Collider().tag, "wall"))
       {
         //We hit a wall...what should we do???
         //Players takes damage.
         //Restart level.
       }
    }    
}
