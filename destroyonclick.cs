using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyonclick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}