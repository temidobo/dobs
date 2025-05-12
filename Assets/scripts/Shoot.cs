using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletSpawnposition;
    public float shootForce = 500;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           GameObject bulletClone =  Instantiate(bullet, bulletSpawnposition.position,  Quaternion.identity );
            bulletClone.GetComponent<MeshRenderer>().material.color = Color.black;
            bulletClone.GetComponent<Rigidbody>()
                .AddForce(transform.forward * shootForce);
        }
    }
}
