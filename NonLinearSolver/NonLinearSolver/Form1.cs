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
        public MainForm()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            ExpressionParser parser = new ExpressionParser();

            // Create value instances
            DoubleValue xval = new DoubleValue();

            // Add values for variables x and y
            parser.Values.Add("x", xval);

            // Создадим список точек
            PointPairList list = new PointPairList();
            double xmin = 0.0;
            double xmax = 0.0;
            double step = 0.1;
            try
            {
                xmin = Convert.ToDouble(valueA.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to convert A to a Double.");                
            }
            catch (OverflowException)
            {
                MessageBox.Show("'A' is outside the range of a Double.");                
            }

            try
            {
                xmax = Convert.ToDouble(valueB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to convert B to a Double.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("'B' is outside the range of a Double.");
            }
            
            try
            {
                step = Convert.ToDouble(textBox5.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to convert to a Double.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("is outside the range of a Double.");
            }

            string function = FunctionText.Text;
            if (function == "") function = "x";
            // Заполняем список точек
            list.Clear();
            for (double x = xmin; x <= xmax; x += step)
            {
                // добавим в список точку
                xval.Value = x; // Update value of "x"
                list.Add(x, parser.Parse(function));

            }
            DrawGraph(list);
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
        private void DrawGraph(PointPairList list)
        {
            // Получим панель для рисования
            GraphPane pane = zGC1.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve(FunctionText.Text, list, Color.Blue, SymbolType.Circle);
            pane.Title.Text = "График на отрезке " + valueA.Text + ":" + valueB.Text;

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
            ExpressionParser parser = new ExpressionParser();
            PointPairList list = new PointPairList();
             string function = FunctionText.Text;         
            DoubleValue xval = new DoubleValue();

            // Add values for variables x
            parser.Values.Add("x", xval);
           
            if (function == "") function = "x";
            // Заполняем список точек
            list.Clear();
                 // добавим в список точку
            try
            {
                xval.Value = Convert.ToDouble(textBox4.Text); ; // Update value of "x"
            }
            catch (FormatException)
            {
                MessageBox.Show("Расчитайте корень");
            }
            
            list.Add(xval.Value, parser.Parse(function));

            
            DrawGraphRoot(list);

        }
        private void DrawGraphRoot(PointPairList list)
        {
            // Получим панель для рисования
            GraphPane pane = zGC1.GraphPane;                

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve(textBox4.Text, list, Color.Red, SymbolType.Triangle);
            pane.Title.Text = "График на отрезке " + valueA.Text + ":" + valueB.Text;

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
