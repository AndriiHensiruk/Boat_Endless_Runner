using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float speed = 15.0f;
    private int value = 50;
   private PlayerHealth  playerHealth;
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }
    private void OnTriggerEnter(Collider other)
    {
        playerHealth.TakeValue(value);
        Destroy(gameObject);
       // Instantiate(effectPrefab, transform.position, transform.rotation);

    }
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
