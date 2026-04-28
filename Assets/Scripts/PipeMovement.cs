using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float m_moveSpeed;

    private void Update()
    {
        MovePipe();
    }

    private void MovePipe()
    {
        transform.Translate(Vector3.left * (m_moveSpeed * Time.deltaTime));
    }
}
