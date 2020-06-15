using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBlock : MonoBehaviour
{

    public GameObject prefabBlock;
    void Awake()
    {
        Transform parent =  gameObject.transform;
        Vector3 parentPos = parent.localPosition;
        for (int z = 0; z < 8; z++)
        {
            for (int x = 0; x < 7; x++)
            {
                GameObject block = Instantiate(prefabBlock, parent);
                block.transform.position = new Vector3(parentPos.x + x * block.transform.localScale.x, parentPos.y, parentPos.z + z * block.transform.localScale.z);
            }
        }
    }
}