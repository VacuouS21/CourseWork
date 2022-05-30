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

    public static string name;

    public static int firstLevel;
    public static int secondLevel;
    public static int thiirdLevel;

    public static int bossLevel;
    public static string bossCheck;
    public static UserStorage user;
    public static void newAll(string nameIn, int first, int second,int third,int ball, string mark,UserStorage userIn)
    {
        name = nameIn;
        firstLevel = first;
        secondLevel = second;
        thiirdLevel = third;
        bossLevel = ball;
        bossCheck = mark;
        user = userIn;
    }
    
    

    
//public static int trueObject = firstTrueNumber * secondTrueNumber;
}
