# LogInPageWPF

## Description
`LogInPageWPF` is a modern Windows Presentation Foundation (WPF) application designed to demonstrate robust user authentication and interactive calendar views. The project adheres to the Model-View-ViewModel (MVVM) architectural pattern, promoting clean separation of concerns and enhancing testability and maintainability.

## Technologies
- **.NET Core 3.1 / .NET Framework 4.7.2**: Target framework depending on the specific needs and compatibility requirements.
- **WPF**: For building the UI.
- **C#**: Programming language.

## Getting Started

### Prerequisites

- Visual Studio 2019 or later with the .NET desktop development workload installed.
- .NET Core 3.1 SDK or .NET Framework 4.7.2 SDK.

### Installation

1. **Clone the Repository**
   - Use Git to clone the repository to your local machine:
   ```bash
   git clone https://your-repository-url-here
   cd LogInPageWPF
2. Open the Project
    - Open the solution file (LogInPageWPF.sln) in Visual Studio.
3. Restore NuGet Packages
    - Ensure that all NuGet packages are restored properly to resolve dependencies.
4. Build the Project
    - Build the project by right-clicking on the solution in Solution Explorer and selecting "Build Solution".
5. Run the Application
    - Start the application by pressing `F5` or clicking on the "Start Debugging" button to launch the application with debugging enabled.

## Project Structure
```bash
LogInPageWPF (Solution)
│
└───LogInPageWPF (Project)
    │
    ├───Properties
    │   └───AssemblyInfo.cs
    │
    ├───Converters
    │   └───InvertedBooleanToVisibilityConverter.cs
    │
    ├───Models
    │   └───User.cs
    │
    ├───ViewModels
    │   ├───LoginViewModel.cs
    │   ├───MainViewModel.cs
    │   └───RelayCommand.cs
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
- Converters/: Includes custom value converters used in the application's views.
- Models/: Defines the data models representing the entities in the application.
- ViewModels/: Contains the logic for handling view data and interactions.
- Views/: Holds the XAML files and code-behind for the user interfaces.
- Styles/: Contains XAML styles that are applied globally or across multiple views.
- App.xaml: The application's startup file which includes global settings and resource dictionaries.

