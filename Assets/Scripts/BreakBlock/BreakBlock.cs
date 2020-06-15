using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlock : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Destroy(this.gameObject);
    }
}
