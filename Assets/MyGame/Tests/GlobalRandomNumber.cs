using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalRandomNumber: MonoBehaviour
{
    //Для верхнего поля, RandomNumber
    public static Queue<string> randomNumbersForText = new Queue<string>();

    //Для последующего умножения
    public static int firstTrueNumber;
    public static int secondTrueNumber;

    //Для вывода на объект
    public static int falseFirstObject;
    public static int falseSecondObject;
//public static int trueObject = firstTrueNumber * secondTrueNumber;
}
