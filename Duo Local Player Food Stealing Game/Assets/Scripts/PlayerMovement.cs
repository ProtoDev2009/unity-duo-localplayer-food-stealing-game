using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] KeyCode forwardKey;
    [SerializeField] KeyCode backKey;
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode rightKey;

    public float moveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = new Vector3(getInputVector().x, 0f, getInputVector().y);
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }

    private Vector2 getInputVector()
    {
        Vector2 inputVector = new Vector2();

        if (Input.GetKey(forwardKey)) inputVector.y += 1;
        if (Input.GetKey(backKey)) inputVector.y -= 1;
        if (Input.GetKey(leftKey)) inputVector.x -= 1;
        if (Input.GetKey(rightKey)) inputVector.x += 1;

        inputVector = inputVector.normalized;

        return inputVector;
    }
}
