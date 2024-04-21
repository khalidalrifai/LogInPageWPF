# LogInPageWPF

## Description
`LogInPageWPF` is a Windows Presentation Foundation (WPF) application designed to demonstrate a modern login interface with user authentication and navigation capabilities. It uses the MVVM (Model-View-ViewModel) architectural pattern to separate business logic from UI concerns, enhancing testability and maintainability.

## Technologies
- **.NET Core 3.1 / .NET Framework 4.7.2** (depending on the project configuration)
- **WPF**
- **C#**

## Project Structure
```bash
LogInPageWPF (Solution)
│
└───LogInPageWPF (Project)
    │
    ├───Converters
    │   └───InvertedBooleanToVisibilityConverter.cs
    │
    ├───Models
    │   └───User.cs
    │
    ├───ViewModels
    │   ├───LoginViewModel.cs
    │   └───MainViewModel.cs
    │
    ├───Views
    │   ├───LoginPage.xaml
    │   ├───LoginPage.xaml.cs
    │   ├───MainWindow.xaml
    │   └───MainWindow.xaml.cs
    │
    ├───Styles
    │   └───Styles.xaml
    │
    ├───App.xaml
    └───App.xaml.cs
```

## Key Components
Converters/: Includes custom value converters used in the application's views.
Models/: Defines the data models representing the entities in the application.
ViewModels/: Contains the logic for handling view data and interactions.
Views/: Holds the XAML files and code-behind for the user interfaces.
Styles/: Contains XAML styles that are applied globally or across multiple views.
App.xaml: The application's startup file which includes global settings and resource dictionaries.

