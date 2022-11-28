using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chim : MonoBehaviour
{
    public GameObject blood;
    private Pont p;
    
    private void Start()
    {
        
        p = GameObject.FindObjectOfType<Pont>().GetComponent<Pont>();
       
    }
    void OnMouseDown()
    {
        //Instantiate(blood, transform.position, Quaternion.identity);
        p.point += 100;
       
        Destroy(gameObject);
    
        Instantiate(blood, transform.position, Quaternion.identity);
    }
}
