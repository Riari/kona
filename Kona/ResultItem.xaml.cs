using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Kona
{
    /// <summary>
    /// Interaction logic for ResultItem.xaml
    /// </summary>
    public partial class ResultItem : UserControl
    {
        [Description("Title")]
        public string Title
        {
            get => (string)TitleLabel.Content;
            set => TitleLabel.Content = value;
        }

        [Description("Description")]
        public string Description
        {
            get => (string)DescriptionLabel.Content;
            set => DescriptionLabel.Content = value;
        }

        public ResultItem()
        {
            InitializeComponent();
        }
    }
}
