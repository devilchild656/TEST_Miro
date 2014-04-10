using System;

class PointInsideCircleAndOutsideOfRectangle
{
    static void Main()
    {
        double pointX = 1;
        double pointY = 1.5;

        double circleCX = 1;
        double circleCY = 1;
        double circleR = 1.5;
        double circleD;
        bool insideCircle = false;

        double rectTop = 1;
        double rectLeft = -1;
        double rectWidth = 6;
        double rectHeight = 2;
        //chech if x coordinate of the point is inside rectangle
        bool isInsideX = (pointX >= rectLeft) && (pointX <= (rectWidth - rectLeft));
        //chech if y coordinate of the point is inside rectangle
        bool isInsideY = (pointY <= rectTop) && (pointY >= (rectTop - rectHeight));
        bool insideRect = false;

        //check if point is inside the circle
        circleD = Math.Sqrt(((pointX - circleCX) * (pointX - circleCX)) + ((pointY - circleCY) * (pointY - circleCY)));

        if ((circleD * circleD) <= (circleR * circleR))
        {
            insideCircle = true;
            //Console.WriteLine("inside circle");
        }
        else
        {
            insideCircle = false;
            //Console.WriteLine("outside circle");
        }

        //check if point is inside the rectangle
        if (isInsideX && isInsideY)
        {
            insideRect = true;
            //Console.WriteLine("inside rect");
        }
        else
        {
            insideRect = false;
            //Console.WriteLine("outside rect");
        }

        //chech if point is inside the circle and outside of the rectangle
        if (insideCircle && !insideRect)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}