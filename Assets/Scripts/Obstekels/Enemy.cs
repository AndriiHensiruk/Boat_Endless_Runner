using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    private Rigidbody enemyrb;
    private GameObject player;
    private float reactdistance = 300f;  

    // for faire
    public GameObject _bullet;
    public float bulletSpeed = 2000;
    public Transform pof;
    public Transform barrel;


    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        Vector3 targetpos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);

        if (distance <= reactdistance)
        {
            StartCoroutine(Shoot());
        }
        else
        {
            transform.LookAt(targetpos);
        }

        if ((transform.position.z - player.transform.position.z) < -3f)
            Destroy(gameObject, 3f);
    }

   IEnumerator Shoot()
    {
        Debug.Log("Fire");
        GameObject bullet = Instantiate(_bullet, pof.position, Quaternion.identity);
        Rigidbody rb = bullet.AddComponent<Rigidbody>();
        rb.velocity = bulletSpeed * pof.forward;
        yield return new WaitForSeconds(2f);
        Destroy(bullet, 3f);
        
    }
}