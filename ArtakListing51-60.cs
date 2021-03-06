using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Baryshev6Listing51_60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Этот класс реализует интерфейс IComparer
        /// </summary>
        public class ListViewColumnSorter : IComparer
        {
            /// <summary>
            /// Номер колонки, по которой проводится сортировка
            /// </summary>
            private int ColumnToSort;
            /// <summary>
            /// Порядок, в котором проводится сортировка (например 'Ascending')
            /// </summary>
            private SortOrder OrderOfSort;
            /// <summary>
            /// Объект, проводящий нечувствительную к регистру сортировку
            /// </summary>
            private CaseInsensitiveComparer ObjectCompare;
            /// <summary>
            /// Конструктор. Инициализирует различные элементы
            /// </summary>
            public ListViewColumnSorter()
            {
                // Инициализировать колонку значением 0
                ColumnToSort = 0;
                // Иниацилизировать порядок сортировки значением 'none'
                OrderOfSort = SortOrder.None;
                // Инициализировать объект CaseInsensitiveComparer
                ObjectCompare = new CaseInsensitiveComparer();
            }
            /// <summary>
            /// Этот метод унаследован от интерфейса IComparer. Он сравнивает
            /// два переданных ему объекта, не обращая внимания на регистр
            /// </summary>
            /// <param name="x">Первый объект для сравнения</param>
            /// <param name="y">Второй объект для сравнения</param>
            /// <returns>Результат сравнения. '0' в случае равенства,
            /// отрицательный если 'x' меньше 'y' и положительный
            /// если 'x' больше 'y'</returns>
            public int Compare(object x, object y)
            {
                int compareResult;
                ListViewItem listviewX, listviewY;
            // Преобразует объекты для сравнения в объекты ListViewItem
 listviewX = (ListViewItem)x;
                listviewY = (ListViewItem)y;
                // Сравнивает 2 значения
                compareResult = ObjectCompare.Compare(
                listviewX.SubItems[ColumnToSort].Text,
                listviewY.SubItems[ColumnToSort].Text);
                // Подсчитывает возвращаемый результат, базируясь на результате
                // сравнения
                if (OrderOfSort == SortOrder.Ascending)
                {
                    // Выбрана сортировка по возрастанию, возвращаем результат
                    // операции сравнения
                    return compareResult;
                }
                else if (OrderOfSort == SortOrder.Descending)
                {
                    // Выбрана сортировка по убыванию, возвращаем результат
                    // операции сравнения со знаком минус
                    return (-compareResult);
                }
                else
                {
                    // Возвращаем 0, чтобы показать равенство
                    return 0;
                }
            }
            /// <summary>
            /// Получает или возвращает номер колонки, к которой применять
            /// сортировку (по умолчанию 0).
            /// </summary>
            public int SortColumn
            {
                set
                {
                    ColumnToSort = value;
                }
                get
                {
                    return ColumnToSort;
                }
            }
            /// <summary>
            /// Устанавливает порядок сортировки (например, 'Ascending').
            /// </summary>
            public SortOrder Order
            {
                set
                {
                    OrderOfSort = value;
                }
                get
                {
                    return OrderOfSort;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            lvwColumnSorter.Items.Clear();
            lvwColumnSorter.Items.Add("Алла");
            lvwColumnSorter.Items.Add("София");
            lvwColumnSorter.Items[0].UseItemStyleForSubItems = false;
            lvwColumnSorter.Items[0].SubItems.Add("Пугачева", Color.Pink, Color.Yellow, Font);
            lvwColumnSorter.Items[1].UseItemStyleForSubItems = false;
            lvwColumnSorter.Items[1].SubItems.Add("Ротару", Color.Teal,
            Color.Violet, Font);
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.button5, "Это кнопка\r\nСамая обычная кнопка");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {
            if (contextMenuStrip1.SourceControl == cmenuOpen)
            {
                cmenuOpen.Text = "Label";
            }
            else
                cmenuOpen.Text = "Button";

            //set interval to 5 seconds
            timerMenu.Interval = 5000;
            timerMenu.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
            timerMenu.Stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            // Create a root node.
            TreeNode rootNode = treeView1.Nodes.Add("Коты");
            TreeNode childNode = rootNode.Nodes.Add("Барсик");
            childNode.Tag = "Барсик - большой и умный кот";
            childNode = rootNode.Nodes.Add("Рыжик");
            childNode.Tag = "Рыжик - очень любопытный кот";
            childNode = rootNode.Nodes.Add("Мурзик");
            childNode.Tag = "Мурзик - ленивый кот";
            childNode = rootNode.Nodes.Add("Пушок");
            childNode.Tag = "Пушок - белый и пушистый кот";
            // Раскрываем все узлы дерева
            rootNode.ExpandAll();
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Получим узел в текущей позиции мыши
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);
            // Установим ToolTip, только если мышь задержалась на узле
            if ((theNode != null))
            {
                // Проверяем, что свойство tag не пустое
                if (theNode.Tag != null)
                {
                    // Меняем ToolTip, если мышь переместилась на другой узел
                    if (theNode.Tag.ToString() !=
                    this.toolTip1.GetToolTip(this.treeView1))
                    {
                        this.toolTip1.SetToolTip(this.treeView1,
                        theNode.Tag.ToString());
                    }
                }
                else
                {
                    this.toolTip1.SetToolTip(this.treeView1, "");
                }
            }
            else // Если указатель не над узлом, то очистим подсказку
            {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Переключаемся на другую вкладку при помощи SelectedTab
            this.tabControl1.SelectedTab = this.tabPage2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Переключаемся на другую вкладку при помощи SelectedIndex
            this.tabControl1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // не работает
            this.button11.Focus();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // работает
            this.button11.Focus();
        }
    }
}

