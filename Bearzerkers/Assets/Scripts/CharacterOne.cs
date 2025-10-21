using UnityEngine;

public class CharacterOne : MonoBehaviour
{
    public GameObject projectile;

    void Start()
    {
        // Instantiate at the spawner's position and rotation
        Instantiate(projectile, transform.position, transform.rotation);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate at a specific position and with no rotation
            Instantiate(projectile, new Vector3(0, 5, 0), Quaternion.identity);
        }
    }
}