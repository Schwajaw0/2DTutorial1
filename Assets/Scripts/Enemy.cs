using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] Image healthbar;
    [SerializeField] float healthAmount = 100f;

    [SerializeField] GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.InitiateGameOver();
            //if (healthAmount <= 0)
            {
                //GameManager.instance.InitiateGameOver();
            }
            //else 
            //{
                //TakeDamage(25);
            //}
        }
        else
        {
            GameManager.instance.IncreaseScore(10);
        }
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
    private void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthbar.fillAmount = healthAmount / 100f;
    }
}
