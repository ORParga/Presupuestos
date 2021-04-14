using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presupuestos
{
    public enum DRAW_MODE { NORMAL, HIGHTLIGHT, SELECTED, FOCUSED };
    public class Selectable_FileValues
    {
        public string type;
        public List<ControlPoint_FileValues> ControlPoint_FileValues_list;
        public Selectable_FileValues()
        {

        }
        public Selectable_FileValues(ISelectable selectable,string Type)
        {
            ControlPoint_FileValues_list = ControlPoint_FileValues.ToFileValues(selectable.ControlPoints);
            type = Type;
        }
        public static List<Selectable_FileValues> ToFileValues(List<ISelectable> selectable_list)
        {
            List<Selectable_FileValues> selectable_FileValues_list = new List<Selectable_FileValues>();

            if (selectable_list == null) return null;
            foreach (ISelectable selectable in selectable_list)
            {
                if (selectable is SRoom)
                {
                    selectable_FileValues_list.Add(new Selectable_FileValues(selectable, "SRoom"));
                }
                if (selectable is SLine)
                {
                    selectable_FileValues_list.Add(new Selectable_FileValues(selectable, "SLine"));
                }
            }

            return selectable_FileValues_list;
        }
        public List<ControlPoint> toControlPoints(ISelectable owner)
        {
            List<ControlPoint> returnControlPoints = new List<ControlPoint>();
            if (ControlPoint_FileValues_list == null) return returnControlPoints;

            for(int index=0;index< ControlPoint_FileValues_list.Count; index++)
            {
                returnControlPoints.Add(new ControlPoint(owner, index, ControlPoint_FileValues_list[index].X, ControlPoint_FileValues_list[index].Y));
            }

            return returnControlPoints;
        }
    }
    public interface ISelectable
    {
        bool HightLight { get; set; }
        bool Selected {get; set; }
        bool Focused{ get; set ; }
        bool Moving { get; set; }
        ControlPoint LastPoint { get; }

        /// <summary>
        /// Comprueba si el mouse está sobre el elemento
        /// </summary>
        /// <param name="workArea">workArea</param>
        /// <param name="MouseX">CoordenadaX en coordenadas Screen</param>
        /// <param name="MouseY">CoordenadaY en coordenadas Screen</param>
        /// <returns>Tru si el mouse está encima</returns>
        bool IsMouseOver(WorkArea workArea, int MouseX, int MouseY);

        /// <summary>
        /// Test if the Mouse is over a control point
        /// </summary>
        /// <param name="workArea">the workArea of the using workPanel</param>
        /// <param name="MouseX">velue returned in the MouseEventArgs by the OnMouseMove method</param>
        /// <param name="MouseY">velue returned in the MouseEventArgs by the OnMouseMove method</param>
        /// <returns>If the mouse is over any control point, this method must returns the control point
        /// This method must return null otherwise. 
        /// Also, this method must turn on or off the hightlight property
        /// The method must ensure the ISelectable owner and int index are correct when this method returns</returns>
        ControlPoint IsMouseOverControlPoint(WorkArea workArea, int MouseX, int MouseY);

        // The user is moving a selectable, The End and Origin points must be in Work Area coordinates
        void MovingSelectable(Punto OriginWA, Punto EndWA);

        //The User has finished of moving a selectable, the changes must be saved
        void MoveEndSelectable(Punto OriginWA, Punto EndWA);

        List<ControlPoint> ControlPoints { get; set; }
        List<PropertyRow> properties { get; set; }

        void SetMode(DRAW_MODE drawMode);
        void CopyingSelectable();
        bool IsInsideOfBox(WorkArea workArea,Punto corner, Punto oppositeCorner);
        void Draw(WorkArea workArea, Graphics g);
        void DrawAsSelected(WorkArea workArea, Graphics g);
        void DrawAsFocused(WorkArea workArea, Graphics g);
        void DrawAsMoving(WorkArea workArea, Graphics g);
        void DrawAsHightLight(WorkArea workArea, Graphics g);
        void DrawAsCreating(WorkArea workArea, Graphics g);
        void CreatingWithMouse(WorkArea workArea, double x1, double y1, double x2, double y2);
        void CreatingWithMouseWA(double point1WA_x1, double point1WA_y, double point2WA_x, double point2WA_y);
        void CreatingWithMouseWA(Punto point1WA, Punto point2WA);
        void CreatingWithMouse_StepByStep(List<Punto> mouseClicks, double X_WA, double Y_WA);
        void CreatingWithMouse_StepByStep(List<Punto> mouseClicks, Punto MouseWA);
        void EndCreatingWithMouse_StepByStep(List<Punto> mouseClicks);
        double sizeAbsolute();

        double sizeConverted();
        void MovingControlPoint(Punto pointOriginWA, Punto pointEndWA, ControlPoint controlPoint);
        void MoveEndControlPoint(Punto pointOriginWA, Punto pointEndWA, ControlPoint controlPoint);

        void setDebugger(frmDebugger frmDebugger);
    }
}
