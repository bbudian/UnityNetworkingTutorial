//adapted from example script available at
//https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    [SerializeField] private float m_RotationSpeed;

    private Rigidbody m_Rigidbody;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * m_Speed;
        float rotation = Input.GetAxis("Horizontal") * m_RotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        Quaternion turn = Quaternion.Euler(0.0f, rotation, 0.0f);
        m_Rigidbody.MovePosition(m_Rigidbody.position + transform.forward * translation);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turn);
    }
}
