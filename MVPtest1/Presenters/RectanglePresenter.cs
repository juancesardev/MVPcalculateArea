using MVPtest1.Models;
using MVPtest1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPtest1.Presenters
{
    public class RectanglePresenter
    {
        IRectangle _rectangleView;

        public RectanglePresenter(IRectangle view)
        {
            _rectangleView = view;
        }

        public void CalculateAreaText()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = double.Parse(_rectangleView.LengthText);
            rectangle.Breadth = double.Parse(_rectangleView.BreadthText);

            _rectangleView.AreaText = rectangle.CalculateArea().ToString();
        }
    }
}
