using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCInteraction : MonoBehaviour
{
    public string battleSceneName = "BattleScene"; // ��ȯ�� ��Ʋ �� �̸� ����
    private bool isPlayerInRange = false; // �÷��̾ NPC�� ��ȣ�ۿ� ���� ���� �ִ��� ����

    // �� �����Ӹ��� ȣ��Ǵ� Update �Լ�
    private void Update()
    {
        // �÷��̾ ���� ���� �ְ� 'E' Ű�� ������ �� �� ��ȯ
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(battleSceneName);
        }
    }

    // �÷��̾ NPC�� �浹�� �� ȣ��Ǵ� �Լ�
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            // ��ȣ�ۿ� �޽��� UI�� Ȱ��ȭ�� �� ���� (��: "Press E to start battle")
        }
    }

    // �÷��̾ ������ ����� �� ȣ��Ǵ� �Լ�
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            // ��ȣ�ۿ� �޽��� UI�� ��Ȱ��ȭ�� �� ����
        }
    }
}
