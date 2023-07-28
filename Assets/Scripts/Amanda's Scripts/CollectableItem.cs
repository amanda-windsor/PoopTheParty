using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public enum RarityLevel
    {
        Common,
        Uncommon,
        Rare,
        Legendary
    }

    public RarityLevel rarity; // The rarity level of the item
    public float spawnRate; // The spawn rate of the item (0-1)

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Add the item to the player's inventory
            AddToInventory();

            // Destroy the item in the game world
            Destroy(gameObject);
        }
    }

    private void AddToInventory()
    {
        // Add the item to the player's inventory
        // You can implement your own inventory system or use Unity's built-in Inventory system
    }
}
