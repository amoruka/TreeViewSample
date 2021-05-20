# TreeViewSample
Product TreeView is a sample of database based application. The application demonstrate using TreeView control for view of hierarchical data of mixed types.

## Task
The application should keep data about products and categories in database. A product belongs to one specific category. The category can be nested in another category. So we have a hierarchy of categories and products where products are leaves and categories are nodes of tree. The application should display the hierarchy in treeview.

## Prerequisites

You need the following tools in order to run/edit the solution.

- Microsoft Visual Studio (Latest recommended)

- MySQL

## Steps
### 1 step - set up connection between app and DB
* Install needed nuget package Entity Framework Core provider for chosen database. 
In this demo [Pomelo.EntityFrameworkCore.MySQL](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql) is used.
* Create and configurate `DBContext` subclass.

### 2 step - create models for Product and Category
* Create model classes for [Product](https://github.com/amoruka/TreeViewSample/blob/main/Model/Product.cs) and [Category](https://github.com/amoruka/TreeViewSample/blob/main/Model/Category.cs).
In this demo Product model has only property `Name` because it is needed for view of product.
Category model also has property `Name` and lists of subcategories and products in this category.
* Run app to create DB.
* Use any way to fill test data into DB.
Demo application delete and create database and fill test data every time in running.

### 3 step - create viewmodels
* Create viewmodels for Product and Category models.
* CategoryViewModel 
* `MainWindowViewModel` aggregate list of Category viewmodels.

### 4 step - configurate treeview bindings
* Specify MainWindow DataContext
```
DataContext = new MainWindowViewModel(categories);
```
* Add TreeView control in MainWindow and bind to property `Categories` in MainWindowViewModel.
```
<TreeView x:Name="treeView" ItemsSource="{Binding Categories}">
</TreeView>
```
* After specify 2 hierarchical data templates for each types: CategoryViewModel and ProductViewModel.
Hierarchical data template for CategoryViewModel is binding to property Children (composite collection of mixed types).
```
<HierarchicalDataTemplate DataType="{x:Type local:CategoryViewModel}" ItemsSource="{Binding Children}">
    <TextBlock Text="{Binding Name}" />
</HierarchicalDataTemplate>
```
* For ProductViewModel hierarchical data template looks like
```
<HierarchicalDataTemplate DataType="{x:Type local:ProductViewModel}">
    <TextBlock Text="{Binding Name}" />
</HierarchicalDataTemplate>
```
