using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public int movementSpeed;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, movementSpeed));
    }
}
