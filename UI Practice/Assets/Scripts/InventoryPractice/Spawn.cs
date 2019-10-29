using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector2 itemPos = new Vector2(player.position.x, player.position.y + 5);
        Instantiate(item, itemPos, Quaternion.identity);
    }
}
