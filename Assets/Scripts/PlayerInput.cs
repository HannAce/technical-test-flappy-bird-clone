using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float m_flapForce;

    private void OnFlap()
    {
        // Attempted to use AddForce, however the jump height not consistent
        //m_rigidbody.AddForce(0, m_flapForce, 0, ForceMode.VelocityChange);
        m_rigidbody.linearVelocity = new Vector3(0, m_flapForce, 0);
    }
    
}
