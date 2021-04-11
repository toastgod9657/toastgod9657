using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addplaycontroledvolocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode KeyPositive;
    [SerializeField]
    KeyCode KeyNegative;

    void FixedUpdate()
    {

        if (Input.GetKey(KeyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;

        if (Input.GetKey(KeyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
    }
}
