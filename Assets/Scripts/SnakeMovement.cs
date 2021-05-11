using UnityEngine;


public class SnakeMovement : MonoBehaviour
{
    public  float speed;
    public float rotationSpeed;
    public GameObject snakeHead;
    public GameObject tailPrefab;


    private void Awake()
    {
        Fever.IsInputEnabled = true;
    }


    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        if (Fever.IsInputEnabled)
        {
            if (Input.GetMouseButton(0))
            {
                if(Input.mousePosition.x > Screen.width/2)
                    transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
                else
                    transform.Rotate(Vector3.up * (-1 * rotationSpeed * Time.deltaTime));
            }
        }
        else
        {
            var feverPosition = new Vector3(0, 0, transform.position.z);
            transform.position = feverPosition;
            transform.rotation = Quaternion.identity;;
        }

        
    }
}
