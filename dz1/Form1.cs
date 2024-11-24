namespace dz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateButtonGrid(int rows, int columns, int buttonWidth, int buttonHeight, int spacing)
        {
            int startX = 50, startY = 50; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button button = new Button();
                    button.Text = (i * columns + j + 1).ToString(); 
                    button.Size = new Size(buttonWidth, buttonHeight);
                    button.Location = new Point(startX + j * (buttonWidth + spacing), startY + i * (buttonHeight + spacing));

                    int rowIndex = i, columnIndex = j; 
                    button.Click += (sender, e) =>
                    {
                        MessageBox.Show($"строка {rowIndex + 1}, столбец {columnIndex + 1}");
                        ((Button)sender).Enabled = false;
                    };

                    this.Controls.Add(button);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButtonGrid(3, 4, 80, 40, 10);
        }
    }
}
