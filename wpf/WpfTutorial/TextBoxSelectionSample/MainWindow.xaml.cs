using System;
using System.Windows;
using System.Windows.Controls;

namespace TextBoxSelectionSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxBase_OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            // Remember that the properties, `SelectionStart`, `SelectionLength`, and `SelectedText`, are all both 
            // readable and writable. For example, one could use the `SelectedText` property to insert and select a
            // string. However, the `TextBox` must have focus, for example, by calling the `Focus()` method, for
            // this technique to work.
            var textBox = sender as TextBox;
            TextStatus.Text = $"Selection starts at character #{textBox!.SelectionStart}";
            TextStatus.Text += Environment.NewLine;
            TextStatus.Text += $"Selection is {textBox.SelectionLength} characters long";
            TextStatus.Text += Environment.NewLine;
            TextStatus.Text += $"Selected text: '{textBox.SelectedText}'";
        }
    }
}