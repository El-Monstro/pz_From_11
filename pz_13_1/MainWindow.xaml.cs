using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

namespace pz_13_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Account _account;
        private Caretaker _caretaker;

        public MainWindow()
        {
            InitializeComponent();
            _account = new Account(1000); // Изначальный баланс
            _caretaker = new Caretaker();
            UpdateBalance();
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(AmountTextBox.Text, out amount) && amount > 0)
            {
                _caretaker.SaveState(_account);
                _account.Deposit(amount);
                UpdateBalance();
            }
            else
            {
                MessageBox.Show("Введите корректную сумму.");
            }
        }

        // Обработчик снятия со счета
        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(AmountTextBox.Text, out amount) && amount > 0)
            {
                _caretaker.SaveState(_account);
                _account.Withdraw(amount);
                UpdateBalance();
            }
            else
            {
                MessageBox.Show("Введите корректную сумму.");
            }
        }

        // Обработчик отмены последней транзакции
        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            _caretaker.RestoreState(_account);
            UpdateBalance();
        }

        // Обновление отображаемого баланса
        private void UpdateBalance()
        {
            BalanceTextBox.Text = _account.Balance.ToString("0.00");
        }
    }
}
