using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeImage : MonoBehaviour
{
    public Image image; // ������ �� Image ���������
    public float delayBeforeFadeIn = 2f; // �������� ����� ������� ���������
    public float fadeInDuration = 1f; // ������������ ���������
    public float delayBeforeFadeOut = 2f; // �������� ����� ������� ������������
    public float fadeOutDuration = 1f; // ������������ ������������

    void Start()
    {
        // ������������� ��������� ������������ �������� � 0
        Color initialColor = image.color;
        initialColor.a = 0f;
        image.color = initialColor;

        // ��������� �������� ��� ��������� ������������
        StartCoroutine(FadeSequence());
    }

    IEnumerator FadeSequence()
    {
        // ���� ��������� ���������� ������� ����� ������� ���������
        yield return new WaitForSeconds(delayBeforeFadeIn);

        // ���������
        yield return Fade(image, 1f, fadeInDuration);

        // ���� ��������� ���������� ������� ����� ������� ������������
        yield return new WaitForSeconds(delayBeforeFadeOut);

        // ������������
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
            yield return null; // ���� ��������� ����
        }

        // ����������, ��� ������������ ����������� ����� � ������� ��������
        img.color = targetColor;
    }
}