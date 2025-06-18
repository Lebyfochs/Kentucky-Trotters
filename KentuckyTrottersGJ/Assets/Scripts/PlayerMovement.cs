using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float player_speed = 5.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, player_speed) * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -player_speed) * Time.deltaTime;

        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(player_speed, 0) * Time.deltaTime;

        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-player_speed, 0) * Time.deltaTime;

        }

    }
}
