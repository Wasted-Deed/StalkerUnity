using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private interface IAction
    {
        public void Launch();
    }

    private class Run : IAction
    {
        private PlayerMovement m_player;

        public Run(PlayerMovement player)
        {
            m_player = player;
        }

        public void Launch()
        {
            Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            m_player.Run(direction.normalized);
        }
    }

    private GameObject playerObject;
    private PlayerMovement playerMovement;

    private IAction[] actions;

    private void Awake()
    {
        playerObject = LevelManager.Instance.PlayerObject;
        playerMovement = playerObject.GetComponent<PlayerMovement>();
        actions = new IAction[] { new Run(playerMovement) };
    }

    private void Update()
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Launch();
        }
    }
}
