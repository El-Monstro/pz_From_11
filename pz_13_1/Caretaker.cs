using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13_1
{
    public class Caretaker
    {
        private readonly List<Memento> _history = new List<Memento>();
        private int _currentMemento = -1;

        // Сохранение текущего состояния
        public void SaveState(Account account)
        {
            // Убираем все последующие снимки (если были транзакции после восстановления)
            _history.RemoveRange(_currentMemento + 1, _history.Count - _currentMemento - 1);

            // Сохраняем текущее состояние счета
            _history.Add(account.Save());
            _currentMemento++;
        }

        // Восстановление состояния
        public void RestoreState(Account account)
        {
            if (_currentMemento >= 0)
            {
                account.Restore(_history[_currentMemento]);
                _currentMemento--;
            }
            else
            {
                Console.WriteLine("Нет доступных состояний для восстановления.");
            }
        }
    }
}
