using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField]
    private float _moveSpeed = 2f;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 movement = transform.TransformDirection(direction) * Time.deltaTime * _moveSpeed;
        _controller.Move(movement);
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("PC Collision");
    }

}
