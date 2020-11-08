using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollider : MonoBehaviour
{

    //Função teste usando triggers de um sphere collider
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
