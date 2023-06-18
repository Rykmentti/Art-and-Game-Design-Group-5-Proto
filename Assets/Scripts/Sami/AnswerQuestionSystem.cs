using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerQuestionSystem : MonoBehaviour
{
    [SerializeField] TMP_InputField answerInputField;
    [SerializeField] TMP_Text questionText;

    string answerText;
    // Start is called before the first frame update
    void Start()
    {
        questionText = GameObject.Find("QuestionText(TMP)").GetComponent<TMP_Text>();
        answerInputField = GameObject.Find("AnswerInputField(TMP)").GetComponent<TMP_InputField>();
        answerInputField.gameObject.SetActive(false);
        questionText.gameObject.SetActive(false);

        answerInputField.onEndEdit.AddListener((answer) => { CheckForAnswerForQuestion1(answer); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() // If you click GameObject with AnswerQuestionSystem script, this will activate.
    {
        Debug.Log("Object Was Clicked!");
        SetQuestionAndAnswer();
    }

    void SetQuestionAndAnswer()
    {
        questionText.gameObject.SetActive(true);
        answerInputField.gameObject.SetActive(true);

        if (gameObject.name == "FirstQuestionTree")
        {
            questionText.text = "What is 1 + 1";
            answerText = "2";
        }
        if (gameObject.name == "SecondQuestionTree")
        {
            questionText.text = "Put Second Question here";
            answerText = "Put Second question Answer here";
        }
        if (gameObject.name == "ThirdQuestionTree")
        {
            questionText.text = "Put Third Question here";
            answerText = "Put Third Question Answer here";
        }
    }

    void CheckForAnswerForQuestion1(string answer)
    {
        Debug.Log("Answer was: " + answer);
        Debug.Log("Correct answer is: " + answerText);

        if (answer == answerText)
        {
            Debug.Log("You answer correct!");
            Destroy(gameObject);

            answerInputField.gameObject.SetActive(false);
            questionText.gameObject.SetActive(false);

        }
        if (answer != answerText)
        {
            Debug.Log("You answer was incorrect");
        }
    }
}
