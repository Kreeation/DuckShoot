using UnityEngine;
using UnityEngine.InputSystem;

public class look_control : MonoBehaviour
{
    public GameObject Player;

    Vector2 mousemovement;

    float xrotation,yrotation;
    float camera_offset;
    float mousesensitivity =20;
    // Start is called before the first frame update
    void Start()
    {
        camera_offset=transform.position.y-Player.transform.position.y;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = Player.transform.position;
        position.y += camera_offset;
        transform.position = position;
        mousemovement = Mouse.current.delta.ReadValue();
        xrotation += mousemovement.y * Time.deltaTime * mousesensitivity;
        xrotation=Mathf.Clamp(xrotation,-90,90);
        yrotation +=mousemovement.x*Time.deltaTime*mousesensitivity;
        transform.rotation = Quaternion.Euler(xrotation, yrotation, 0);
        Player.transform.rotation = Quaternion.Euler(0,yrotation,0);
        
    }
}
