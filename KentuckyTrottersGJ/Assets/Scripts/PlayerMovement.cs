using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float player_speed = 5.0f;

    public GameObject lassoPrefab;

    public Ray ray;

    public Transform playerPoint;

    public Vector3 clickPosition;

    public int lerpFramesCount = 45;
    int elapsedFrames = 0;

    //Vector3 mousePos;

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

        float lerpRatio = (float)elapsedFrames / lerpFramesCount;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, player_speed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -player_speed) * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(player_speed, 0) * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-player_speed, 0) * Time.deltaTime;

        }

        if (Input.GetMouseButtonDown(0))
        {

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Instantiate(lassoPrefab, new Vector3(playerPoint.position.x, playerPoint.position.y), Quaternion.identity);

            //TO DO: Lerp the lasso towards the mouse position!

            //lassoPrefab.transform.position = Vector3.Lerp(playerPoint.position, ray.origin,lerpRatio);
            //elapsedFrames = (elapsedFrames + 1) % (lerpFramesCount + 1);

            //lassoPrefab.transform.position += new Vector3(ray.origin.x, ray.origin.y) * Time.deltaTime;

            //lassoPrefab.transform.position = Vector3.MoveTowards(playerPoint.position.normalized, ray.origin.normalized, player_speed * Time.deltaTime);



            //Instantiate(lassoPrefab, new Vector3(ray.origin.x, ray.origin.y), Quaternion.identity);
        }

        //Debug.DrawRay(transform.position, transform.forward, Color.cyan);
        Debug.Log(playerPoint.position);
    }
}
