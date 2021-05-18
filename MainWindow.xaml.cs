using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreeViewSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            

            using var context = new AppContext();

            context.Categories.AddRange(CreateTestData());

            context.SaveChanges();
        }

        private List<Category> CreateTestData()
        {
            return new List<Category>
            {
                new Category
                {
                    Name = "Laptops, Tablets & PCs",
                    Subcategories = new List<Category>
                    {
                        new Category
                        {
                            Name = "Notebooks",
                            Subcategories = new List<Category>
                            {
                                new Category
                                {
                                    Name = "Apple MacBook",
                                    Products = new List<Product>
                                    {
                                        new Product { Name = "Apple MacBook Air 13.3''" },
                                        new Product { Name = "Apple MacBook Pro 13.3''" },
                                        new Product { Name = "Apple MacBook Pro 16''" },
                                    }
                                },
                                new Category
                                {
                                    Name = "Gaming Laptop",
                                    Products = new List<Product>
                                    {
                                        new Product { Name = "Razer Blade Pro 17" },
                                    }
                                },
                                new Category
                                {
                                    Name = "Ultrabooks"
                                }
                            },
                            Products = new List<Product>
                            {
                                new Product { Name = "Acer Predator Triton 300SE" },
                                new Product { Name = "HP Chromebook x360" },
                                new Product { Name = "Samsung Galaxy Book S" },
                            }
                        },
                        new Category
                        {
                            Name = "Tablet PCs"
                        },
                        new Category
                        {
                            Name = "Desctop PCs"
                        },
                        new Category
                        {
                            Name = "Servers"
                        }
                    }
                }
            };
        }
    }
}
