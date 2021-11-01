using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float _followSpeed;

    private Transform _target;
    private GameObject _player;

    private void Awake()
    {
        _player = LevelManager.Instance.PlayerObject;
        _target = _player.transform;
    }

    private void FixedUpdate()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position, _followSpeed * Time.fixedDeltaTime);
        transform.position -= new Vector3(0f, 0f, transform.position.z + 10f);
    }
}
