using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    
    public EnemyHealth enemyHalse;
    public Gate gate;
    public int Damage;
    public int Value;
    
    
    public void Start()
    {
        gate = FindObjectOfType<Gate>();
        enemyHalse = FindObjectOfType<EnemyHealth>();
    }
    public void OnCollisionEnter(Collision co)
    {
        if(co.gameObject.tag == "Enemy")
        {
            enemyHalse.TakeDamage(Damage);
            Destroy(gameObject);
        }

        if(co.gameObject.tag == "Gate")
        {
            gate.TakeValue(Value);
            Destroy(gameObject);

        }
    }
}
