using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    float bulletSpeed = 1100;
    public GameObject bullet;

    AudioSource bulletAudio;

    // Start is called before the first frame update
    void Start()
    {
        bulletAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Fire()
    {
        //shoot
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, 0.5f);

        //Play Audio
        bulletAudio.Play();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
}
