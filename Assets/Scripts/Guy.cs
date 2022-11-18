using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guy : MonoBehaviour
{
    public bool HasTouch = false;
    public float time = 0.0f;
    public float maxtime = 5.0f;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if(HasTouch == true){
            time += Time.deltaTime;
        }
        if(time >= maxtime)
        {
            Destroy(gameObject);
        }
    }

    
    void OnCollisionEnter(Collision collision)
    {
        print("I touched the"+collision.gameObject.name);
       if(collision.gameObject.name == "MC"){
           print("Ohh no you have killed me by bad poetry");
           HasTouch = true;
       } 
        

    }
}
