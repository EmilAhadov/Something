using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    private GameObject _capsule;
    private GameObject _sphere;
    private GameObject _plane;

    private void Start()
    {
        _capsule = GameObject.FindGameObjectWithTag("Capsule");
        _sphere = GameObject.FindGameObjectWithTag("Sphere");
        _plane = GameObject.FindGameObjectWithTag("Parent");
    }
    private void OnCollisionStay(Collision collision)
    {
        _capsule.GetComponent<MeshRenderer>().enabled = false;
        _capsule.GetComponent<CapsuleCollider>().isTrigger = true;

        //------------------------------------------------------------------------------------------------

        _sphere.name = "Entered";
        _sphere.transform.SetParent(_plane.transform);
    }
    private void OnTriggerExit(Collider other)
    {
        _capsule.GetComponent<MeshRenderer>().enabled = true;
        Debug.Log(_capsule.GetComponent<MeshRenderer>().enabled);
        _capsule.GetComponent<CapsuleCollider>().isTrigger = false;
        _capsule.tag = "Entered";
    }
}
