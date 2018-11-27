using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public GameManager GameManagerPrefab;
    
    public override void InstallBindings()
    {
        Container.Bind<GameManager>().FromComponentInNewPrefab(GameManagerPrefab).AsSingle();
    }
}