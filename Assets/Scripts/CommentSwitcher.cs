using UnityEngine;
using TMPro; // Если используете TextMeshPro

public class CommentSwitcher : MonoBehaviour
{
    public TextMeshProUGUI commentText1; // Первое текстовое поле
    public TextMeshProUGUI commentText2; // Второе текстовое поле
    public TextMeshProUGUI commentText3; // Третье текстовое поле
    public GameObject ramka;
    private string[] comments = new string[3]; // Массив для хранения комментариев
    private int currentIndex = 0; // Индекс текущего комментария

    void Start()
    {
        // Инициализация комментариев
        comments[0] = "It seems that there used to be a pond here. But the water is gone, or dried up after a long time... I'm sure it was very beautiful here at one time.";
        comments[1] = "This strange rock reminds me of something. Only something is missing... Water, exactly!";
        comments[2] = "This rock is somehow connected with the lake. Perhaps it's a matter of reflection.";

        // Скрываем комментарии при старте
        HideComments();
    }

    void Update()
    {
        // Проверка нажатия клавиши "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            SwitchComment();
        }
    }

    void UpdateComment()
    {
        // Обновление текста в текстовых полях
        commentText1.text = comments[currentIndex];
        commentText2.text = comments[currentIndex];
        commentText3.text = comments[currentIndex];
    }

    void SwitchComment()
    {
        // Переключение на следующий комментарий
        currentIndex = (currentIndex + 1) % comments.Length;
        UpdateComment();
    }

    void HideComments()
    {
        // Скрываем комментарии
        commentText1.gameObject.SetActive(false);
        commentText2.gameObject.SetActive(false);
        commentText3.gameObject.SetActive(false);
        ramka.SetActive(false);
    }

    void ShowComments()
    {
        // Показываем комментарии
        commentText1.gameObject.SetActive(true);
        commentText2.gameObject.SetActive(true);
        commentText3.gameObject.SetActive(true);
        ramka.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Проверяем, является ли объект игроком
        if (other.CompareTag("Player"))
        {
            // Показываем комментарии и устанавливаем первый комментарий
            ShowComments();
            UpdateComment();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Проверяем, является ли объект игроком
        if (other.CompareTag("Player"))
        {
            // Скрываем комментарии
            HideComments();
        }
    }
}