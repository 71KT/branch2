using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPlaneRotation : MonoBehaviour
{
    public int ydirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, ydirection, 0)* Time.deltaTime);
    }
}
