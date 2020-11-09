using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollider : MonoBehaviour
{

    // Start is called before the first frame update
    SphereCollider colisor;
    public bool backCol;
    void Start()
    {
        colisor = GetComponent<SphereCollider>();
    }


    private void OnTriggerEnter(Collider other)
    {
        backCol = true;
    }
    private void OnTriggerExit(Collider other)
    {
        backCol = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
