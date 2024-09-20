using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    [SerializeField] Image healthbar;
    [SerializeField] float healthAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(healthAmount <= 0)
        {
            GameManager.instance.InitiateGameOver();
        }
        else //(Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamage(25);
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //Heal(10);
        //}
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthbar.fillAmount = healthAmount / 100f;
    }

    //public void Heal(float healingAmount)
    //{
       // healthAmount += healingAmount;
       // healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        //healthbar.fillAmount = healthAmount / 100f;
    //}
}
