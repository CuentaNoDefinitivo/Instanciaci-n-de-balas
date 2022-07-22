using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] GameObject objectToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        BulletsDeath();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void BulletsDeath()
    {
        Destroy(objectToDestroy,2f);
    }
}
