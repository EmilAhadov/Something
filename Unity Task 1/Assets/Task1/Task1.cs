using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject.GetComponent<CapsuleCollider>());
        gameObject.tag = "Changed";
        if (gameObject.CompareTag("Changed"))
        {
            gameObject.name = "Changed";
            if (gameObject.name == "Changed")
            {
                Destroy(gameObject.GetComponent<GameObject>());
            }
        }
    }
}
