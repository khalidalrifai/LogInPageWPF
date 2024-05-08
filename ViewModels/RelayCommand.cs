/* RelayCommand.cs file contains RelayCommand, which is the basic pattern for WPF applications of the MVVM (Model-View-ViewModel). 
 * The RelayCommand allows encapsulating methods that are going to be executed as a response of a command, BUT in a separated way from UI logic. */
using System;
using System.Windows.Input;

namespace LogInPageWPF.ViewModels
{
    public class RelayCommand : ICommand
    {
        // These fields hold the action to execute and the function to determine if it can execute.
        // The Action<object> below defines what the command does.
        // The Func<object, bool>  determines whether the command can execute.
        // NOTE: If the execute action is null, an exception is thrown to ensure that a valid action is always provided.
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        // Constructor that initializes the command
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));     // This ensures a valid action is provided
            _canExecute = canExecute;                                                   // This is an optional condition to check if the command can execute
        }

        // Event that is triggered when changes occur that affect whether the command should execute.
        // It helps the command to re-evaluate its ability to execute when certain conditions change in the application, like changing a data state that the command depends on.
        // It does this by hooking into CommandManager.RequerySuggested, which listens for changes in the UI that might affect command execution,
        // such as focus changes or other user interactions.
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }       // Adds event listeners
            remove { CommandManager.RequerySuggested -= value; }    // Removes event listeners
        }

        // A method to determine if the command can execute in its current state
        public bool CanExecute(object parameter)
        {
            // NOTE: CanExecute determines whether the command can be executed. If _canExecute is not provided, it will always return true.
            // If it is provided, it evaluates the function to decide based on the current state or context (passed as parameter).
            return _canExecute == null || _canExecute(parameter);  // If no canExecute function is provided, it defaults to true
        }

        // Executes the action associated with the command
        public void Execute(object parameter)
        {
            // Here is where the action associated with the command is invoked. It's called when the command is executed (For example a button related to this command is clicked).
            _execute(parameter);
        }
    }
}
