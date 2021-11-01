using UnityEngine;

public class LevelManager : Manager<LevelManager>
{
    private GameObject _playerObject;

    [SerializeField]
    private Transform _startPoint;
    [SerializeField]
    private GameObject _playerPrefab;
    [SerializeField]
    private GameObject _inputControllerPrefab;
    [SerializeField]
    private GameObject _cameraPrefab;
    [SerializeField]
    private GameObject _uIControllerPrefab;

    private GameObject _inputController;
    private GameObject _camera;
    private GameObject _uIController;

    public GameObject PlayerObject => _playerObject;

    private void Awake()
    {
        _playerObject = Instantiate(_playerPrefab, _startPoint);
        _inputController = Instantiate(_inputControllerPrefab);
        _uIController = Instantiate(_uIControllerPrefab);
        _camera = Instantiate(_cameraPrefab);
    }
}
