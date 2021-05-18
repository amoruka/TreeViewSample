using System;
using System.Collections.Generic;
using System.Text;

namespace TreeViewSample
{
    public class MainWindowViewModel
    {
        public List<CategoryViewModel> Categories { get; set; }

        public MainWindowViewModel(List<CategoryViewModel> categories)
        {
            Categories = categories;
        }
    }
}
