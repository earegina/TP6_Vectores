using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speedEnemy = 5.0f;
    public float speedToLook = 10.0f;
    public float liveEnemy = 7.0f;
    //bool isForward = true;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Robot Kyle");
    }
    // Update is called once per frame
    void Update()
    {
        LookAtPlayer2();
        MoveTowards();
        
    }
    private void MoveEnemy(Vector3 direction)
    {
        transform.Translate(speedEnemy * Time.deltaTime * direction);
    }

    private void MoveTowards()
    {
        Vector3 direction   = (player.transform.position - transform.position).normalized;
        transform.position += speedEnemy * direction * Time.deltaTime;
    }

    /*private void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = newRotation;
    }*/
    private void LookAtPlayer2(){
    Quaternion newRotation = Quaternion.LookRotation((player.transform.position - transform.position));
    transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);

}
}