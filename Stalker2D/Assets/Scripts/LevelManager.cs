using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Manager<LevelManager>
{
    private GameObject m_playerObject;

    [SerializeField]
    private Transform startPoint;
    [SerializeField]
    private GameObject playerPrefab;

    public GameObject PlayerObject
    {
        get
        {
            if (m_playerObject == null)
            {
                m_playerObject = Instantiate(playerPrefab, startPoint);
            }
            return m_playerObject;
        }
    }
}
