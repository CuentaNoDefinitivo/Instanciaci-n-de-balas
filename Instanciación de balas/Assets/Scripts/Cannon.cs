using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Object bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo", 0, 1f);
    }

    void Disparo()
    {
        Instantiate(bullet);
    }
}
