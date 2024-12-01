using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Button selectedButton; // Ссылка на кнопку, которую нужно проверить
    public CommentTrigger commentTrigger; // Ссылка на объект с комментарием

    void Update()
    {
        // Проверяем, выбрана ли кнопка
        if (selectedButton != null && selectedButton.gameObject.activeInHierarchy)
        {
            if (selectedButton.interactable && selectedButton.GetComponent<Button>().IsInteractable())
            {
                Debug.Log("Selected button is interactable"); // Отладочное сообщение
                commentTrigger.OnCommentRead(); // Уведомляем объект с комментарием, что записка прочитана
            }
        }
    }
}