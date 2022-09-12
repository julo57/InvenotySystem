using UnityEngine;
public class ItemRespawner : MonoBehaviour
{
    public GameObject Item;
   
    private Transform player;
 
    private void Start()
    {
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

    public void SpawnDroppedItem()
    {
		Vector2 playerPos = new Vector2(player.position.x, player.position.y + 3);
        Instantiate(Item , playerPos , Quaternion.identity);
    }
}
