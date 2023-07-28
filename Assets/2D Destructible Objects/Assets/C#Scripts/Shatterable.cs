using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shatterable : MonoBehaviour, IHittable
{


    public List<Spawner> spawnPoints;

    private SpriteRenderer render;

    void Start()
    {

        render = GetComponent<SpriteRenderer>();
    }

    private void Reset()
    {
        Utils.Collider2DDialogWindow(this.gameObject, false);
    }

    

    public void HitReceived()
    {
        Die();
    }


    public void Die()
    {

            render.enabled = false;

            foreach (Spawner spawn in spawnPoints)
            {
                spawn.Spawn();
            }

            Destroy(gameObject);
        } }
