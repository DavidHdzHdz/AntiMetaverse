using UnityEngine;

public class Mover : MonoBehaviour
{
    GameObject _progresiveAI;
    public int MovementSpeed = 50;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world from metaverse");
        _progresiveAI = GameObject.Find("ProgresiveAI");
        transform.Translate(0, 20, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (_progresiveAI.transform.position.y > 0) transform.Translate(0, -1.0f * Time.deltaTime * MovementSpeed, 0);
        else {
            float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MovementSpeed;
            float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MovementSpeed;

            transform.Translate(xValue, 0, zValue);
        }
    }
}
