using System;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace sorts
{
    public partial class Form1 : Form
    {
        
        private int[] array = [];

        
        private readonly Random random = new();

        
        private readonly string file = "..//..//..//1.txt";

        
        private CancellationTokenSource cts = new();

        
        const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        
        [DllImport("dwmapi.dll", PreserveSig = true)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        
        private void EnableDarkMode()
        {
            
            IntPtr hWnd = this.Handle;
            int useImmersiveDarkMode = 1; 

            
            DwmSetWindowAttribute(hWnd, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useImmersiveDarkMode, sizeof(int));
            ApplyDarkTheme(); 
        }

        
        public Form1()
        {
            InitializeComponent();
            EnableDarkMode(); 
            lbsort.ForeColor = Color.FromArgb(70, 130, 180); 
            rbRand.Checked = true;
            int depthLimit = 2 * (int)Math.Log(array.Length);
            txtDepth.Text = depthLimit.ToString();
        }

        
        private static int[] ReadArrayFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не знайден", filePath);
            }

            string fileContent = File.ReadAllText(filePath);
            
            int[] numbers = fileContent
                .Split(new char[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return numbers;
        }

        
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                array = ReadArrayFromFile(file); 
                lbsort.ForeColor = Color.FromArgb(70, 130, 180); 
                this.lbsort.Text = "  не відсортований"; 
                DisplayArray(array); 
                DrawHistogram(array); 
                int depthLimit = 2 * (int)Math.Log(array.Length);
                txtDepth.Text = depthLimit.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        
        private static void WriteArrayToFile(int[] a, string filePath)
        {
            
            string content = string.Join(" ", a);
            
            File.WriteAllText(filePath, content);
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try { WriteArrayToFile(array, file); } 
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                cts?.Cancel(); 
                int min = int.Parse(txtMin.Text);
                int max = int.Parse(txtMax.Text);
                int count = int.Parse(txtCount.Text);

                
                if (min > max)
                {
                    MessageBox.Show("Мінімальне значення не може бути більше максимального", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMin.Text = txtMax.Text;
                    return;
                }
                if (count <= 0)
                {
                    MessageBox.Show("Кількість елементів має бути більше 0", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCount.Text = "";
                    return;
                }

                
                array = new int[count];
                Random random = new Random();
                for (int i = 0; i < count; i++)
                {
                    array[i] = random.Next(min, max + 1);
                }

                
                lbsort.ForeColor = Color.FromArgb(70, 130, 180);
                this.lbsort.Text = "   не відсортований";

                
                if (rbDesc.Checked)
                {
                    Array.Sort(array);
                    Array.Reverse(array);
                }
                else if (rbAsc.Checked)
                {
                    Array.Sort(array);
                }

                int depthLimit = 2 * (int)Math.Log(array.Length);
                txtDepth.Text = depthLimit.ToString();
                
                DisplayArray(array);
                DrawHistogram(array);

                

            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка введіть правильні числові значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Відбулась помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        private void DisplayArray(int[] a)
        {
            txtArray.Text = string.Join(", ", a);
        }

        
        private void DrawHistogram(int[] a)
        {
            var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            var graphics = Graphics.FromImage(bitmap);

            
            graphics.Clear(Color.FromArgb(50, 50, 50));

            if (a == null || a.Length == 0)
            {
                pictureBox.Image = bitmap;
                return;
            }
            Color myColor = Color.FromArgb(255, 222, 173);
            Brush myBrush = new SolidBrush(myColor);
            float barWidth = pictureBox.Width / (float)a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                float barHeight = (a[i] / (float)a.Max()) * pictureBox.Height;
                graphics.FillRectangle(myBrush, i * barWidth, pictureBox.Height - barHeight, barWidth, barHeight);
            }

            pictureBox.Image = bitmap;
            pictureBox.Refresh(); 
        }

       
        private async void btnMergeSort_Click(object sender, EventArgs e)
        {
            cts?.Cancel(); 
            cts = new CancellationTokenSource(); 
            lbsort.ForeColor = Color.FromArgb(255, 0, 0); 
            lbsort.Text = "       MERGE SORT"; 
            await SortArrayWithVisualizationAsync(MergeSort, cts.Token); 
        }

        
        private async void btnQuickSort_Click(object sender, EventArgs e)
        {
            cts?.Cancel(); 
            cts = new CancellationTokenSource(); 
            lbsort.ForeColor = Color.FromArgb(255, 0, 0); 
            lbsort.Text = "        QUICK SORT"; 
            await SortArrayWithVisualizationAsync(QuickSort, cts.Token); 
        }

        
        private async void btnIntroSort_Click(object sender, EventArgs e)
        {
            cts?.Cancel(); 
            cts = new CancellationTokenSource(); 
            lbsort.ForeColor = Color.FromArgb(255, 0, 0); 
            lbsort.Text = "        INTRO SORT"; 
            await SortArrayWithVisualizationAsync(IntroSort, cts.Token); 
        }

        
        private async Task SortArrayWithVisualizationAsync(Action<int[], int, int, CancellationToken> sortMethod, CancellationToken token)
        {
            int[] arrayCopy = (int[])array.Clone(); 
            await Task.Run(() => sortMethod(arrayCopy, 0, arrayCopy.Length - 1, token), token); 
            array = arrayCopy; 
            DisplayArray(array); 
            DrawHistogram(array); 
            lbsort.ForeColor = Color.FromArgb(34, 139, 34); 
            this.lbsort.Text = "масив відсортований"; 
        }

        
        private void MergeSort(int[] array, int left, int right, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return;
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(array, left, mid, token);
                MergeSort(array, mid + 1, right, token);
                Merge(array, left, mid, right, token);
            }
        }

        
        private void Merge(int[] array, int left, int mid, int right, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return;

            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(array, left, L, 0, n1);
            Array.Copy(array, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
                DrawHistogram(array); 
            }

            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
                DrawHistogram(array); 
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
                DrawHistogram(array); 
            }
        }

        
        private void QuickSort(int[] array, int low, int high, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return;
            if (low < high)
            {
                int pi = Partition(array, low, high, token);
                QuickSort(array, low, pi - 1, token);
                QuickSort(array, pi + 1, high, token);
            }
        }

        
        private int Partition(int[] array, int low, int high, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return low;
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                    DrawHistogram(array); 
                }
            }
            Swap(array, i + 1, high);
            DrawHistogram(array); 
            return i + 1;
        }

        private static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        
        private void IntroSort(int[] array, int left, int right, CancellationToken token)
        {
            int depthLimit = 2 * (int)Math.Log(array.Length);
            IntroSortUtil(array, left, right, depthLimit, token);
            DrawHistogram(array); 
        }

        
        private void IntroSortUtil(int[] array, int left, int right, int depthLimit, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return;
            while (right > left)
            {
                if (right - left < 16)
                {
                    InsertionSort(array, left, right, token);
                    DrawHistogram(array); 
                    return;
                }

                if (depthLimit == 0)
                {
                    HeapSort(array, left, right, token);
                    DrawHistogram(array); 
                    return;
                }

                depthLimit--;
                int p = Partition(array, left, right, token);
                DrawHistogram(array); 
                IntroSortUtil(array, p + 1, right, depthLimit, token);
                DrawHistogram(array); 
                right = p - 1;
            }
        }

        
        private void InsertionSort(int[] array, int left, int right, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return;
            for (int i = left + 1; i <= right; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= left && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                    DrawHistogram(array); 
                }
                array[j + 1] = key;
                DrawHistogram(array); 
            }
        }

        
        private void HeapSort(int[] array, int left, int right, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return;
            int n = right - left + 1;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i, left, token);
            }
            for (int i = n - 1; i > 0; i--)
            {
                Swap(array, left, left + i);
                Heapify(array, i, 0, left, token);
                DrawHistogram(array); 
            }
        }

        
        private void Heapify(int[] array, int n, int i, int left, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return;
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && array[left + l] > array[left + largest])
            {
                largest = l;
            }

            if (r < n && array[left + r] > array[left + largest])
            {
                largest = r;
            }

            if (largest != i)
            {
                Swap(array, left + i, left + largest);
                Heapify(array, n, largest, left, token);
                DrawHistogram(array); 
            }
        }

        
        private void ApplyDarkTheme()
        {
           
            this.BackColor = Color.FromArgb(25, 25, 25);
            this.ForeColor = Color.White;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ListBox || c is PictureBox)
                {
                    c.BackColor = Color.FromArgb(40, 40, 40);
                    c.ForeColor = Color.White;
                }
                else if (c is Button)
                {
                    c.BackColor = Color.FromArgb(63, 63, 70);
                    c.ForeColor = Color.White;
                }
                else
                {
                    c.BackColor = Color.FromArgb(25, 25, 25);
                    c.ForeColor = Color.White;
                }
            }
        }

        private void lbsort_Click(object sender, EventArgs e)
        {

        }
    }
}

