using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreArea : MonoBehaviour
{

    public GameObject effectObject;
   

    public object Text { get; private set; }

    void Start()
    {
        
        effectObject.SetActive(false);
    
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Ball>() != null)
        {
            effectObject.SetActive(true);
           
            
            
            
        }
    }
}
