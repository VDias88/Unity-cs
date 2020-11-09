using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject objeto;
    [SerializeField] private string tag="object" ;
    [SerializeField] private Material hightlight;
    [SerializeField] private Material defaultMaterial;
    private Transform _selection;

    public void Couple(string child) {
        objeto.transform.parent = GameObject.Find(child).transform;
    }
    public void Uncouple() {
        objeto.transform.parent = null;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null) {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            var selection = hit.transform;
            if (selection.CompareTag(tag)) { 
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null) 
             {
             selectionRenderer.material = hightlight;
            if (Input.GetMouseButtonDown(0))
             {
                        hit.transform.parent = GameObject.Find("hand.R_end").transform;
             }
                }
             _selection = selection;
            }
            
        }
    }
}
