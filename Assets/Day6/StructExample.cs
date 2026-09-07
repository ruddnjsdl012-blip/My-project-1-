using UnityEngine;

public class StructExample : MonoBehaviour
{
    private void Start()
    {
        Point point = new Point(2, 2);
        point.X = 3;

        Debug.Log($"좌표(x: {point.X}, y: {point.Y}]");
        // - 구조체는 값형이고
        // - 클래스 (객체)는 참조형입니다. 

      
        
    }
}
