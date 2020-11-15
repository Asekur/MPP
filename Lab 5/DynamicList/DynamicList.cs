using System;
using System.Collections;
using System.Collections.Generic;
using NLog;

namespace DynamicList
{
    //параметр универсального типа
    [ExportClass]
    public class DynamicList<T> : IEnumerable<T>
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();
        private T[] _arrayItems;
        private const int _defaultCount = 10;
        private int _currentAmount = 0;

        //количество элементов в массиве
        public int Count => _currentAmount;
        //для доступа к элементам по индексу
        public T[] Items => _arrayItems;

        public DynamicList()
        {
            _arrayItems = new T[_defaultCount];
        }

        public void Add(T value)
        {
            if (_currentAmount == _arrayItems.Length)
            {
                //увеличение размера массива в два раза
                _log.Info("Exending array from " + _arrayItems.Length + " to " + _arrayItems.Length * 2);
                T[] newArray = new T[_arrayItems.Length * 2];
                _arrayItems.CopyTo(newArray, 0);
                _arrayItems = newArray;
            }
            _arrayItems[_currentAmount] = value;
            _currentAmount++;
            _log.Info("The value " + value + " was added to array");
        }

        public void Remove(T value)
        {
            int indexOfValue = Array.IndexOf<T>(_arrayItems, value, 0, _currentAmount);
            if (indexOfValue < 0)
            {
                _log.Info("Element " + value + " isn't found in list");
                return;
            }
            RemoveAt(indexOfValue);
            _log.Info("Removed element " + value);
        }

        public void RemoveAt(int indexInArray)
        {
            if (indexInArray >= _currentAmount)
            {
                _log.Info("Removed index " + indexInArray + " is out of range");
                return;
            }
            T[] copyArray = new T[_arrayItems.Length];
            _arrayItems.CopyTo(copyArray, 0);
            Array.Copy(_arrayItems, indexInArray + 1, copyArray, indexInArray, _arrayItems.Length - indexInArray - 1);
            _log.Info("Element " + _arrayItems[indexInArray] + " [" + indexInArray + "] was deleted");
            _arrayItems = copyArray;
            _currentAmount--;
        }

        public void Clear()
        {
            _arrayItems = new T[_defaultCount];
            _currentAmount = 0;
            _log.Info("List is clear");
        }

        public IEnumerator<T> GetEnumerator()
        {
            //используется для итерации по коллекции
            foreach (var value in Items)
            {
                //возвращает последовательность IEnumerable
                yield return value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
