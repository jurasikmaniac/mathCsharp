using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace DiffApp
{
    public partial class GraphForm : Form
    {
        public GraphForm(List<ResultRow> r)
        {
            InitializeComponent();
            updateGraph(r);
        }
        private void updateGraph(List<ResultRow> r)
        {
            GraphPane pane = zedGraphControl1.GraphPane;
            PointPairList inputPoints = new PointPairList();
            foreach (var item in r)
            {
                inputPoints.Add(item.X, item.Y[0]);
            }
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("Graph", inputPoints, Color.Blue, SymbolType.None);
           
           
            // Включим отображение сетки
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            // Обновляем график
            zedGraphControl1.Invalidate();
        }

    }
}
