using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float followSpeed;

    private Transform m_target;
    private GameObject m_player;

    private void Awake()
    {
        m_player = LevelManager.Instance.PlayerObject;
        m_target = m_player.transform;
    }

    private void FixedUpdate()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        transform.position = Vector3.Lerp(transform.position, m_target.position, followSpeed * Time.fixedDeltaTime);
        transform.position -= new Vector3(0f, 0f, transform.position.z + 10f);
    }
}
