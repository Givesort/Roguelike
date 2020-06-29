using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector3 Movement { get; private set; }
    public bool Fire { get; private set; }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Movement = new Vector3(x, y, 0);
        Fire = Input.GetKey("space");
    }
}
