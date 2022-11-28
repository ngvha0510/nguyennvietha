using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Character;
    private Vector3 target;
    public AudioSource aus;
    public AudioClip click;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

        
    }

    // Update is called once per frame
    void Update()
    {
 
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        Character.transform.position = new Vector2(target.x, target.y);

        if(Input.GetMouseButtonDown(0) == true)
        {
            aus.PlayOneShot(click);
        }
       
       
    }
}
