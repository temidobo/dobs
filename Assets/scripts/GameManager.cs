using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject originalGameobject;
    public Transform spawnPositon;
    public Transform parentTransform;
    void Start()
    {
        Instantiate(originalGameobject,
            spawnPositon.position, 
            Quaternion.identity,
            parentTransform);
    }

    void Update()
    {
        
    }
}
