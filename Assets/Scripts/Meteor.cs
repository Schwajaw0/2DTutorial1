using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] float speed = 6f;
    [SerializeField] float rotationSpeed = 120f;

    [SerializeField] GameManager manager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotateMeteor();
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
    }

    private void RotateMeteor()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.InitiateGameOver();
        }
       
       
        Destroy(collision.gameObject);
        
    }
}
