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

namespace Drawer
{
    public partial class Form1 : Form
    {
        private PointPairList inputPoints = new PointPairList();
        private PointPairList selectedPoints = new PointPairList();
        private PointPairList lagrangePoints = new PointPairList();
        private GraphPane pane;

        public Form1()
        {
            InitializeComponent();
            pane = zedGraph.GraphPane;
            updateGraph();
        }
        private void updateUI()
        {
            updateDataGrid();
            updateGraph();
        }
        /// <summary>
        /// Обработчик события MouseClick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zedGraph_MouseClick(object sender, MouseEventArgs e)
        {
            if (!addPointCheckBox.Checked)
            {
                return;
            }
            // Сюда будут записаны координаты в системе координат графика
            double x, y;

            // Пересчитываем пиксели в координаты на графике
            // У ZedGraph есть несколько перегруженных методов ReverseTransform.
            zedGraph.GraphPane.ReverseTransform(e.Location, out x, out y);

            inputPoints.Add(x,y);
            inputPoints.Sort();
            if (lagrangeCheckBox.Checked)
            {
                updateLagrangePoints();
            }

            updateUI();
        }

        private void updateDataGrid()
        {
            pointsDataGridView.Rows.Clear();
            int i = 0;
            foreach (var p in inputPoints)
            {
                pointsDataGridView.Rows.Add(new string[] {i.ToString(), p.X.ToString(), p.Y.ToString() });
                i++;
            }
        }


        private void updateGraph()
        {

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("Sinc", inputPoints, Color.Blue, SymbolType.None);
            LineItem selectedPoint = pane.AddCurve("Sinc", selectedPoints, Color.Red, SymbolType.Circle);
            selectedPoint.Line.IsVisible = false;
            selectedPoint.Symbol.Fill.Color = Color.Red;
            selectedPoint.Symbol.Fill.Type = FillType.Solid;
            selectedPoint.Symbol.Size = 10;

            if (lagrangeCheckBox.Checked)
            {
                LineItem lagrangeCurve = pane.AddCurve("Sinc", lagrangePoints, Color.Olive, SymbolType.None);
            }

            // Включим отображение сетки
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            // Обновляем график
            zedGraph.Invalidate();
        }
        private void updateLagrangePoints()
        {
            lagrangePoints.Clear();
            double step = (pane.XAxis.Scale.Max - pane.XAxis.Scale.Min) / 500;
            for (double i = pane.XAxis.Scale.Min; i < pane.XAxis.Scale.Max; i+=step)
            {
                lagrangePoints.Add(i,Interpolator.lagrange(i,inputPoints));
            }
        }

        private void pointsDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                inputPoints.RemoveAt(e.RowIndex);
                updateLagrangePoints();
                updateUI();
            }
        }

        private void pointsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedPoints.Clear();
            for (int i = 0; i < pointsDataGridView.SelectedRows.Count; i++)
            {
                selectedPoints.Add(inputPoints.ElementAt(pointsDataGridView.SelectedRows[i].Index));
            }
            updateGraph();
        }

        private void zedGraph_ZoomEvent(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
        {
            updateLagrangePoints();
            updateGraph();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lagrangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateLagrangePoints();
            updateUI();
        }

        private void addPointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateLagrangePoints();
            updateUI();
        }

    }
}
