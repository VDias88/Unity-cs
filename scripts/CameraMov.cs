using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class CameraMov : MonoBehaviour
{
    public float sensitivity = 20f;
    public float maxYAngle = 90f;
    Rigidbody rgb;
    public float speed=20f;
    public float jump = 10f;
    public float runspeed;
    bool Isgrounded;
    public Transform chao;
    public Transform cam;
    float headRotation = 0f;
    public LayerMask groudMaks;
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {   
        //usando objeto Isgrounded e sua distancia do chão para evitar pulos infinitos
        Isgrounded = Physics.CheckSphere(chao.position, 0.4f, groudMaks);
        //pegando inputs de mouse
        float x1 = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float y1 = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime * -1f;
        //girando player no eixo x de acordo com o mouse
        transform.Rotate(0f, x1, 0f);
        cam.localEulerAngles = new Vector3(headRotation, 0f, 0f);
        headRotation += y1;
        //math.clamp usado para evitar rotação da camera a baixo dos -90 graus e acima dos 90 
        headRotation = Mathf.Clamp(headRotation, -90f, 90f);
        cam.localEulerAngles = new Vector3(headRotation, 0f, 0f);
        //input de teclado 
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        //vetor3 usado para mover rigidbody
        Vector3 moveBy = transform.right * x + transform.forward * z;
        rgb.MovePosition(transform.position + moveBy.normalized * speed * Time.deltaTime);
        //checar pulo
        if (Input.GetKeyDown(KeyCode.Space)&&(Isgrounded))
        {
            rgb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        }
        //correr 
        if (Input.GetKey(KeyCode.LeftShift)&&(Isgrounded))
        {
            rgb.MovePosition(transform.position + moveBy.normalized * runspeed * Time.deltaTime);
        }
    }
}
