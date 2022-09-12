using UnityEngine;

public class Movement : MonoBehaviour
{
	public float Speed = 0;

	private void Update()
	{
		float horizontalAxis = Input.GetAxis("Horizontal");
		float verticalAxis = Input.GetAxis("Vertical");

		Vector2 inputVector = new Vector2(horizontalAxis, verticalAxis);

		transform.Translate(inputVector * Speed * Time.deltaTime);
	}
}
