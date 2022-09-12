using UnityEngine;

public class DropItem : MonoBehaviour
{
    private AddingItemsToList invetory;
	
	public int i;

    private void Start()
    {
		invetory = GameObject.FindGameObjectWithTag("Player").GetComponent<AddingItemsToList>();
	}

    private void Update()
    {
        if(transform.childCount == 0)
        {
            invetory.IsFull[i] = false;
        }
    }

    public void DropItems()
    {
        foreach(Transform child in transform)
        {
            child.GetComponent<ItemRespawner>().SpawnDroppedItem();
			GameObject.Destroy(child.gameObject);
			invetory.Cross[i].SetActive(false);
		}
	}
}
