using UnityEngine;

public class Pickiing_up : MonoBehaviour
{
	public GameObject ItemButton;

	private AddingItemsToList addingItemsToList;
	
	private void Start()
	{
		addingItemsToList = GameObject.FindGameObjectWithTag("Player").GetComponent<AddingItemsToList>();
	}

	private void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag == ("Player"))
		{
			for (int i = 0; i < addingItemsToList.Slots.Length; i++)
			{
				if (addingItemsToList.IsFull[i] == false)
				{
					addingItemsToList.IsFull[i] = true;
					addingItemsToList.Cross[i].SetActive(true);
					Instantiate(ItemButton, addingItemsToList.Slots[i].transform, false);
					Destroy(gameObject);
					break;
				}
			}
		}
	}
}
//cubes[i].SetActive(false)
