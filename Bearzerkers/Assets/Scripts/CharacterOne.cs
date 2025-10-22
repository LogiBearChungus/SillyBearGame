using UnityEngine;

public class CharacterOne : MonoBehaviour
{
    public GameObject projectile;
    public GameObject character;

    void Start()
    {
        // Instantiate at the spawner's position and rotation
        //Instantiate(projectile, transform.position, transform.rotation);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate at the character's position, with no rotation
            Instantiate(projectile, character.transform.position + character.transform.forward * 1f, character.transform.rotation);

        }
    }
}
