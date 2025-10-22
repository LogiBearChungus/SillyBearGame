using UnityEngine;
using System.Collections;

public class CharacterOne : MonoBehaviour
{
    public Stats stats;

    public GameObject projectile;
    public GameObject character;

    void Start()
    {
        StartCoroutine(ShootLoop());
    }

    IEnumerator ShootLoop()
    {
        while (true)
        {
            ShootIceProjectile();
            yield return new WaitForSeconds(stats.attackSpeed);
        }
    }

    void ShootIceProjectile()
    {
        Instantiate(projectile, character.transform.position + character.transform.forward * 1f, character.transform.rotation * Quaternion.Euler(90f, 0f, 0f));
    }
}
