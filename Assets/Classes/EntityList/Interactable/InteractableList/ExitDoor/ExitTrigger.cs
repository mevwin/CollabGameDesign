using System;
using NUnit.Framework;
using UnityEngine;

public class ExitTrigger : Interactable
{
    [SerializeField] private GameManager.GameState nextGameState;
    [SerializeField] private DungeonLevelList dungeonLevelList;

    protected override void InitializeStates() { }

    public override void OnTriggerEnter(Collider collider)
    {
        if (isActive && collider.gameObject.TryGetComponent(out Player player))
        {
            GameManager gameManager = GameManager.GetManager();
            LevelManager levelManager = LevelManager.GetManager();

            levelManager.SetDungeonList(dungeonLevelList);
            gameManager.LoadGameState(nextGameState);
        }
    }
}
