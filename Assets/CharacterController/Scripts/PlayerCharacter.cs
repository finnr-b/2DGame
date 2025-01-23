//There are four errors in this package

using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController), typeof(PlayerInput))]
public class PlayerCharacter : MonoBehaviour
{
    //Character controller
    private CharacterController Cc => this.GetComponent<CharacterController>();
    //Player input actions
    private PlayerInput PlayerInput => this.GetComponent<PlayerInput>();
    //Current direction input
    private Vector3 currentDirectionInput;

	private void Update()
	{
        Vector3 moveDirection = new Vector3(currentDirectionInput.x, 0, currentDirectionInput.y);
        Cc.Move(moveDirection * Time.deltaTime * 100);
	}

	public void OnMovement(InputAction.CallbackContext context){
        currentDirectionInput = context.ReadValue<Vector2>();
    }
}