using UnityEngine;

public class InputController : MonoBehaviour
{
    private interface IAction
    {
        void Launch();
    }

    private class Run : IAction
    {
        private PlayerMovement _player;

        public Run(PlayerMovement player)
        {
            _player = player;
        }

        public void Launch()
        {
            Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            _player.Run(direction.normalized);
        }
    }

    private class Inventory : IAction
    {
        public void Launch()
        {
            if (Input.GetButtonDown("Inventory"))
            {

            }
        }
    }

    private GameObject _playerObject;
    private PlayerMovement _playerMovement;

    private IAction[] actions;

    private void Awake()
    {
        _playerObject = LevelManager.Instance.PlayerObject;
        _playerMovement = _playerObject.GetComponent<PlayerMovement>();
        actions = new IAction[] { new Run(_playerMovement) };
    }

    private void Update()
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Launch();
        }
    }
}
