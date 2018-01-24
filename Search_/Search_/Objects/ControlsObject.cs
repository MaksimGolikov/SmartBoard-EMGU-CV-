using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search_.Objects;
using System.Drawing;
using System.Windows.Forms;

namespace Search_.Objects
{
    class ControlsObject
    {

        private int selectedObj;
        private List<myObject> usedObjects;

        Point startScalePosition;
        double oldDistanceToHand;
        bool isStartScaleposition;


        Operations lastOperation;


        public List<myObject> GetAllObjects { get => usedObjects; }
        public Operations LastOperations { get => lastOperation; set => lastOperation = value; }
       


        public ControlsObject()
        {
            usedObjects = new List<myObject>();         
            lastOperation = Operations.NONE;
            selectedObj = 0;
            startScalePosition = new Point(0, 0);
            oldDistanceToHand = 0;

            isStartScaleposition = false;
        }

        public void AddNewObject(Bitmap image, Point position)
        {          
            usedObjects.Add(new myObject(usedObjects.Count + 1,
                                         image,
                                         position ));           
        }
        public void DeleteObject()
        {
            var idOfObject = usedObjects.FindIndex(o => o.Id == selectedObj);
            if (idOfObject >= 0)
            {
                usedObjects.RemoveAt(idOfObject);
            }
            
        }


        public void SelectObject(Point middleOfGesture)
        {
            foreach (var obj in usedObjects)
            {
                if (obj.Position.IntersectsWith(new Rectangle(middleOfGesture, new Size (1,1))) )
                {
                    selectedObj = obj.Id;
                    break;
                }
            }
        }        


        public void DeselectObject()
        {
            selectedObj = 0;
        }

       

        public void ControlObjectState(Point middleOfGesture)
        {
            var idOfObject = usedObjects.FindIndex(o => o.Id == selectedObj);
           
            if (idOfObject >= 0)
            switch (lastOperation)
            {
                case Operations.BREAK:                      
                    isStartScaleposition = false;
                    break;
                case Operations.MOVE:
                    usedObjects[idOfObject].Move(middleOfGesture);
                    break;

                case Operations.SCALE:

                    if (!isStartScaleposition)
                    {
                        startScalePosition = new Point(usedObjects[idOfObject].Position.X + usedObjects[idOfObject].Position.Width / 2,
                                                usedObjects[idOfObject].Position.Y + usedObjects[idOfObject].Position.Height / 2);

                        oldDistanceToHand = Math.Sqrt(Math.Pow((startScalePosition.X - middleOfGesture.X), 2) +
                                                      Math.Pow((startScalePosition.Y - middleOfGesture.Y), 2));

                        isStartScaleposition = true;
                    }

                    double distanceToHend = Math.Sqrt( Math.Pow( (startScalePosition.X - middleOfGesture.X), 2) + 
                                                       Math.Pow( (startScalePosition.Y - middleOfGesture.Y), 2) );

                   
                    float newScale = 0;
                    /*Hand positon at left or top  - scale down*/
                    if ( (middleOfGesture.X < startScalePosition.X) )
                    {
                        newScale = -((float)distanceToHend / 100 );
                    }
                    /*Hand position at right or down - scate up*/
                    if ((middleOfGesture.X > startScalePosition.X))
                    {
                        newScale = ((float)distanceToHend / 100 );
                    }

                    usedObjects[idOfObject].Scale(newScale);                        
                                                                             
                    break;
                    case Operations.DELETE:
                        DeleteObject();
                        lastOperation = Operations.BREAK;
                        break;
            }
        }



        public bool IsAnyObjectSelected()
        {
            bool result = false;

            if (selectedObj > 0)
            {
                result = true;
            }
            return result;
        }
        

    }
}
