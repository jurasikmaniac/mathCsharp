using info.lundin.math;
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

namespace NonLinearSolver
{
    public partial class MainForm : Form
    {
        PointPairList list = new PointPairList();
        PointPairList listRoot = new PointPairList();
        GraphPane pane;

        public MainForm()
        {
            InitializeComponent();
            pane = zGC1.GraphPane;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            updatePoints();
            DrawGraph();
            DrawGraphRoot();
            
            
        }

        private void updatePoints()
        {
            Function f = new Function(FunctionText.Text);
           
           
            list.Clear();
            double step = (pane.XAxis.Scale.Max - pane.XAxis.Scale.Min) / 500;
            for (double i = pane.XAxis.Scale.Min; i < pane.XAxis.Scale.Max; i += step)
            {
                //newtonPoints.Add(i, Interpolator.NewtonInterpolator(i, inputPoints));
                list.Add(i, f.getValueInX(i));
            }
        }

        private void zedGraph_ZoomEvent(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
        {            
            updatePoints();
            DrawGraph();
            DrawGraphRoot();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.label1, Properties.Resources.String1);


        }

        
        /// <summary>
        /// Рисовать график
        /// </summary>
        /// <param name="list">Массив точек</param>
        private void DrawGraph()
        {
            // Получим панель для рисования
          
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve(FunctionText.Text, list, Color.Blue, SymbolType.None);
            pane.Title.Text = "График";

            //myCurve.Line.IsVisible =true;
            //// !!!
            //// Цвет заполнения отметок (ромбиков) - колубой
            myCurve.Symbol.Fill.Color = Color.Blue;

            //// !!!
            //// Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;

            //// !!!
            //// Размер ромбиков
            myCurve.Symbol.Size = 2;
            // Горизонтальная линия на уровне y = 0 рисоваться не будет
            pane.YAxis.MajorGrid.IsZeroLine = true;
            pane.XAxis.MajorGrid.IsZeroLine = true;

            //zGC1.AxisChange();

            // Обновляем график
            zGC1.Invalidate();
        }

        private void buttonBi_Click(object sender, EventArgs e)
        {
            double xl = Convert.ToDouble(textBox1.Text);
            double xr = Convert.ToDouble(textBox2.Text);
            double eps = Convert.ToDouble(textBox3.Text);
            string formula = FunctionText.Text;
            Function f = new Function(formula);
            if (Math.Sign(f.getValueInX(xl))!=Math.Sign(f.getValueInX(xr)))
            {
                textBox4.Text = Solver.bisectionMethod(f, xl, xr, eps).ToString();
            }
            else
            {
                MessageBox.Show("На краях данного отрезка функция одного знака!");
            }
            

        }

        private void buttonHord_Click(object sender, EventArgs e)
        {
            double xl = Convert.ToDouble(textBox1.Text);
            double xr = Convert.ToDouble(textBox2.Text);
            double eps = Convert.ToDouble(textBox3.Text);
            string formula = FunctionText.Text;
            Function f = new Function(formula);
            if (Math.Sign(f.getValueInX(xl)) != Math.Sign(f.getValueInX(xr)))
            {
                textBox4.Text = Solver.hordMethod(f, xl, xr, eps).ToString();
            }
            else
            {
                MessageBox.Show("На краях данного отрезка функция одного знака!");
            }
           
        }

        private void buttonNewton_Click(object sender, EventArgs e)
        {
            double xl = Convert.ToDouble(textBox1.Text);
            double xr = Convert.ToDouble(textBox2.Text);
            double eps = Convert.ToDouble(textBox3.Text);
            string formula = FunctionText.Text;
            Function f = new Function(formula);
            if (Math.Sign(f.getValueInX(xl)) != Math.Sign(f.getValueInX(xr)))
            {
                textBox4.Text = Solver.NewtonMethod(f, xl, xr, eps).ToString();
            }
            else
            {
                MessageBox.Show("На краях данного отрезка функция одного знака!");
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private void DrawGraphRoot()
        {
            Function f = new Function(FunctionText.Text);        
            
           
          
            // Заполняем список точек
            listRoot.Clear();
            double x = 0D;
                 // добавим в список точку
            try
            {
                x = Convert.ToDouble(textBox4.Text); ; // Update value of "x"
            }
            catch (FormatException)
            {
                
            }
            
            listRoot.Add(x, f.getValueInX(x));

            
     
            // Получим панель для рисования
            GraphPane pane = zGC1.GraphPane;                

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve(textBox4.Text, listRoot, Color.Red, SymbolType.Triangle);
            pane.Title.Text = "График";

            //myCurve.Line.IsVisible =true;
            //// !!!
            //// Цвет заполнения отметок (ромбиков) - колубой
            myCurve.Symbol.Fill.Color = Color.Blue;

            //// !!!
            //// Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;

            //// !!!
            //// Размер ромбиков
            myCurve.Symbol.Size = 7;
            // Горизонтальная линия на уровне y = 0 рисоваться не будет
            pane.YAxis.MajorGrid.IsZeroLine = true;
            pane.XAxis.MajorGrid.IsZeroLine = true;

            //zGC1.AxisChange();

            // Обновляем график
            zGC1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GraphPane pane = zGC1.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            zGC1.Invalidate();
        }

        




    }
}
