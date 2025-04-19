using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneTransfer : MonoBehaviour
{
    [Header("Настройки")]
    [Tooltip("Тег пустого объекта в новой сцене, куда переместится игрок")]
    public string spawnPointTag = "Respawn"; // Стандартный тег Unity для точек возрождения

    private static GameObject playerInstance;
    private Vector3 savedPosition;
    private Quaternion savedRotation;

    private void Awake()
    {
        // Реализация синглтона, чтобы игрок не дублировался
        if (playerInstance == null)
        {
            playerInstance = gameObject;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Подписываемся на событие загрузки сцены
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        // Отписываемся при уничтожении объекта
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Вызывается при загрузке новой сцены
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Ищем пустой объект с указанным тегом
        GameObject spawnPoint = GameObject.FindGameObjectWithTag(spawnPointTag);

        if (spawnPoint != null)
        {
            // Телепортируем игрока к точке
            transform.position = spawnPoint.transform.position;
            transform.rotation = spawnPoint.transform.rotation;
        }
        else
        {
            Debug.LogWarning($"Объект с тегом '{spawnPointTag}' не найден в сцене '{scene.name}'. Игрок остался на прежней позиции.");
        }
    }

    // Метод для ручного перехода на другую сцену
    public void ChangeScene(string sceneName)
    {
        // Сохраняем текущие позицию и поворот (опционально)
        savedPosition = transform.position;
        savedRotation = transform.rotation;

        SceneManager.LoadScene(sceneName);
    }
}
