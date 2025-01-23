//There are four errors in this package

using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController), typeof(PlayerInput))]
public class PlayerCharacter : MonoBehaviour
{
    //Character controller
    private CharacterController cc => this.GetComponent<Character>();
    //Player input actions
    private PlayerInput playerInput => this.GetComponent<PlayerInput>();
    //Current direction input
    private Vector2 currentDirectionInput;

	private void Update()
	{
        Vector3 moveDirection = currentDirectionInput;
        cc.Move(moveDirection * Time.fixedDeltaTime);
	}

	public void OnMovement(InputAction.CallbackContext context){
        currentDirectionInput = context.ReadValue<Vector2>();
    }
}
