using UnityEngine;
public class ItemSpawner : MonoBehaviour
{
	private Vector2 screeBounds;

	private void Start()
	{
		screeBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
	}

	private void SpawningItems()
	{
		Vector2 SpawnDistance = new Vector2( Random.Range(-screeBounds.x, screeBounds.x), Random.Range(-screeBounds.y, screeBounds.y));
		GameObject objectTOSpawn = Instantiate(gameObject) ; 
		objectTOSpawn.transform.position = SpawnDistance;
	}

	private void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag==("Player"))
		{
			SpawningItems();
		}
	}
}
