using UnityEngine;
using System.Collections;
using Rewired;
public class ScriptToStealFrom : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection;
	public int playerId = 0;
	private Player player;

	void Awake ()
	{
		player = ReInput.players.GetPlayer(playerId);
	}	

	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3 (player.GetAxis ("MoveHorizontal"), 0, player.GetAxis ("MoveVertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if(player.GetButton("nobutton"))
			{
				moveDirection.y = jumpSpeed;
			}
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);


	}
}  