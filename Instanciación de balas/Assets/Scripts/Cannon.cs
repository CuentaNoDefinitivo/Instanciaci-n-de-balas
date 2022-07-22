using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Object bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Clone", 0, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }
    void Clone()
    {
        Instantiate(bullet,new Vector3(0, 0, 0),new Quaternion());
        //Instantiate(bullet, transform);
    }
}
