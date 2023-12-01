using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceWorldTransform : MonoBehaviour
{
    //public Vector3 position;
    public Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = position;
        transform.rotation = rotation;
    }
}
