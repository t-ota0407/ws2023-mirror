using UnityEngine;
using Mirror;

public class MyCubeController : NetworkBehaviour
{
    private const float movementStep = 0.04f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (isLocalPlayer)
        {
            float x = 0, y = 0, z = 0;

            if (Input.GetKey(KeyCode.W))
            {
                z = movementStep;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                x = -movementStep;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                z = -movementStep;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                x = movementStep;
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                y = movementStep;
            }
            else if (Input.GetKey(KeyCode.E))
            {
                y = -movementStep;
            }

            CmdMoveCube(x, y, z);
        }
    }

    [Command]
    void CmdMoveCube(float diffX, float diffY, float diffZ)
    {
        Vector3 oldPosition = transform.localPosition;

        transform.localPosition = oldPosition + new Vector3(diffX, diffY, diffZ);
    }
}
