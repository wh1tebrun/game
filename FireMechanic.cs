using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMechanic : MonoBehaviour
{
   public Transform firePoint;
   public GameObject bulletPrefab;
   public float MermiSayisi = 10;



   void Update()
   {
    if(Input.GetButtonDown("Fire1"))
    {
        Shoot();
    }
    if(Input.GetKeyDown("q"))
    {
        Shoot();
    }
   }



   public void Shoot()
   {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);  






   }
   public void Shoot2()
   {
    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);


    
   }
}
