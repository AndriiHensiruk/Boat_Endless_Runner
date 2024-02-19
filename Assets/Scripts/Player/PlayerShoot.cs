using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    RaycastHit hit;
    public GameObject _bullet;
    public float bulletSpeed = 2800;
    public Transform pof;
    public int Damge = 20;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    
    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Fire");
        GameObject bullet = Instantiate(_bullet, pof.position, Quaternion.identity);
        Rigidbody rb = bullet.AddComponent<Rigidbody>();
        rb.velocity = bulletSpeed * pof.forward;
        StartCoroutine(Shoot());
        Destroy(bullet, 3f);
        
    }

    
}
