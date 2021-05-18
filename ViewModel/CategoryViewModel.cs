using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;

namespace TreeViewSample
{
    public class CategoryViewModel
    {
        private readonly Category Category;

        public string Name => Category.Name;

        List<CategoryViewModel> Subcategories => Category.Subcategories?.Select(x => new CategoryViewModel(x)).ToList();

        List<ProductViewModel> Products => Category.Products?.Select(x => new ProductViewModel(x)).ToList();

        /// <summary>
        /// Union of different classes colections
        /// </summary>
        public IList Children => new CompositeCollection
        {
            new CollectionContainer { Collection = Products },
            new CollectionContainer { Collection = Subcategories },
        };

        public CategoryViewModel(Category category)
        {
            Category = category;
        }
    }
}
