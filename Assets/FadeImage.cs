using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeImage : MonoBehaviour
{
    public Image image; // Ссылка на Image компонент
    public float delayBeforeFadeIn = 2f; // Задержка перед началом появления
    public float fadeInDuration = 1f; // Длительность появления
    public float delayBeforeFadeOut = 2f; // Задержка перед началом исчезновения
    public float fadeOutDuration = 1f; // Длительность исчезновения

    void Start()
    {
        // Устанавливаем начальную прозрачность картинки в 0
        Color initialColor = image.color;
        initialColor.a = 0f;
        image.color = initialColor;

        // Запускаем корутину для изменения прозрачности
        StartCoroutine(FadeSequence());
    }

    IEnumerator FadeSequence()
    {
        // Ждем указанное количество времени перед началом появления
        yield return new WaitForSeconds(delayBeforeFadeIn);

        // Появление
        yield return Fade(image, 1f, fadeInDuration);

        // Ждем указанное количество времени перед началом исчезновения
        yield return new WaitForSeconds(delayBeforeFadeOut);

        // Исчезновение
        yield return Fade(image, 0f, fadeOutDuration);
    }

    IEnumerator Fade(Image img, float targetAlpha, float duration)
    {
        Color startColor = img.color;
        Color targetColor = startColor;
        targetColor.a = targetAlpha;

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            img.color = Color.Lerp(startColor, targetColor, elapsedTime / duration);
            yield return null; // Ждем следующий кадр
        }

        // Убеждаемся, что прозрачность установлена точно в целевое значение
        img.color = targetColor;
    }
}