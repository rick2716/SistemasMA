using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizDB : MonoBehaviour
{
    [SerializeField] private List<Question> n_questionList = null;

    [Header("Canvas")]
    public GameObject canvasPreguntas;
    public GameObject canvasOsorio;

    [Header("UI")]
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panelAntes;
    public GameObject panelDespues;

    public Question GetQuestion(bool remove = true)
    {
        if (n_questionList.Count == 0)
            ApagarCanvas();
        if (n_questionList.Count == 2)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
        }
        else if (n_questionList.Count == 1)
        {
            panel2.SetActive(false);
            panel3.SetActive(true);
        }


            int index = Random.Range(0, n_questionList.Count);

        if (!remove)
            return n_questionList[index];

        Question q = n_questionList[index];
        n_questionList.RemoveAt(index);

        return q;
    }

    public void ApagarCanvas()
    {
        canvasPreguntas.SetActive(false);
        canvasOsorio.SetActive(true);

        panelAntes.SetActive(false);
        panelDespues.SetActive(true);
    }
}
