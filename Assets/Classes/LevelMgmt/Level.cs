using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private Transform playerSpawnPoint;
    private GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        gameManager = GameManager.GetManager();

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Start()
    {
        if (gameManager && gameManager.player){
            gameManager.player.SetActive(true);
            gameManager.player.transform.position = playerSpawnPoint.position;   
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
