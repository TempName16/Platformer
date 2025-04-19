using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneTransfer : MonoBehaviour
{
    [Header("���������")]
    [Tooltip("��� ������� ������� � ����� �����, ���� ������������ �����")]
    public string spawnPointTag = "Respawn"; // ����������� ��� Unity ��� ����� �����������

    private static GameObject playerInstance;
    private Vector3 savedPosition;
    private Quaternion savedRotation;

    private void Awake()
    {
        // ���������� ���������, ����� ����� �� ������������
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

        // ������������� �� ������� �������� �����
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        // ������������ ��� ����������� �������
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // ���������� ��� �������� ����� �����
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // ���� ������ ������ � ��������� �����
        GameObject spawnPoint = GameObject.FindGameObjectWithTag(spawnPointTag);

        if (spawnPoint != null)
        {
            // ������������� ������ � �����
            transform.position = spawnPoint.transform.position;
            transform.rotation = spawnPoint.transform.rotation;
        }
        else
        {
            Debug.LogWarning($"������ � ����� '{spawnPointTag}' �� ������ � ����� '{scene.name}'. ����� ������� �� ������� �������.");
        }
    }

    // ����� ��� ������� �������� �� ������ �����
    public void ChangeScene(string sceneName)
    {
        // ��������� ������� ������� � ������� (�����������)
        savedPosition = transform.position;
        savedRotation = transform.rotation;

        SceneManager.LoadScene(sceneName);
    }
}
