using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAttack : MonoBehaviour
{
    public PlayerHealth _playerHealth;
    public int Damage;
    public void Start()
    {
        _playerHealth = FindObjectOfType<PlayerHealth>();
    }
    public void OnCollisionEnter(Collision co)
    {
        if(co.gameObject.tag == "Player")
        {
            _playerHealth.TakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}
