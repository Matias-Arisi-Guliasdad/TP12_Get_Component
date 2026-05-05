using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    CubeScripts cubeData;
 
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Hubo colision");
        cubeData = col.gameObject.GetComponent<CubeScripts>();
        Debug.Log("Nombre del otro objeto:"+ cubeData.ObjectName);

    }
}
