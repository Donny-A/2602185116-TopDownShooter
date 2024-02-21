using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Ship ship;

    public void Awake()
    {
        ship = GetComponent<Ship>();
    }
    private void Update()
    {
       
        ship.SetDirection(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
    }
}
 

