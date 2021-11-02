using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lifePlayer = 3;
    public string namePlayer = "Robot Kyle";
    public float speedPlayer = 1f;
 
    public float cameraAxisX = -90f;
    // Start is called before the first frame update
    void Start()
    {
        
    
    }

    // Update is called once per frame
    void Update()
    {
      Move();
      RotatePlayer();
      
    }

    private void Move()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
    }

    private void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion angulo   = Quaternion.Euler(0, cameraAxisX, 0);
        transform.localRotation = angulo;
    }
}