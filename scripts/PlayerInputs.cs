using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objeto;
    [SerializeField] private Material hightlight;
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
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null) {
                selectionRenderer.material = hightlight;
            }
        }
    }
}
