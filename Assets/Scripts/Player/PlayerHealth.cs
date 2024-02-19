using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public int value = 100;
    public GameObject CanvasDie;
    private BodyPartChanging bodyPartChanging;
    private void Start(){

        bodyPartChanging = FindObjectOfType<BodyPartChanging>();

    }
    
    public void TakeDamage(int Damage)
    {
        health -= Damage;
        if(health <= 0)
        {
            //CanvasDie.SetActive(true);
            Destroy(gameObject);
        }
    }
     public void TakeValue(int Value)
     {
        value += Value;
        if(value > 200)
        {
            bodyPartChanging.ChangeBody();
            value-=200;
        }
        

     }
}
