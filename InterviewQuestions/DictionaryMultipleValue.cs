using System.Collections;

namespace InterviewQuestions
{

    public interface IMultiValueDictionary<K, V> : IEnumerable<KeyValuePair<K, IEnumerable<V>>>
    {
        void Add(K key, V value);
        bool Remove(K key, V value);
        bool RemoveKey(K key);
        IEnumerable<V> Get(K key);
        bool ContainsKey(K key);
    }
    /**
     * 
     * Purpose of yield in C#:
        1. Simplifies Iterator Implementation: Normally, implementing an iterator requires creating a separate class or managing the state of iteration manually.
                                            With yield, C# automatically handles the state of the iteration for you.
        2. Deferred Execution: When you use yield, it produces values one at a time as requested (deferred execution), which can be more memory-efficient, especially when dealing with large collections.
        3. Keeps Code Clean and Simple: By using yield, you avoid having to manually manage the enumerator's state (like tracking the current position in the collection).

        How yield Works in the DictionaryMultipleValue Class:
           1. In the DictionaryMultipleValue class, the yield keyword is used in the GetEnumerator() method to return each KeyValuePair<TKey, IEnumerable<TValue>> one at a time, allowing the class to be iterated over using a foreach loop.
     * 
     * *
     */

    public class DictionaryMultipleValue<TKey, TValue> : IMultiValueDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, List<TValue>> _dictionary;

        public DictionaryMultipleValue()
        {
            _dictionary = new Dictionary<TKey, List<TValue>>();
        }

        // Add a value to the dictionary for the given key
        public void Add(TKey key, TValue value)
        {
            if (!_dictionary.ContainsKey(key))
            {
                _dictionary[key] = new List<TValue>();
            }
            _dictionary[key].Add(value);
        }

        // Remove a specific value for a given key
        public bool Remove(TKey key, TValue value)
        {
            if (_dictionary.ContainsKey(key))
            {
                var values = _dictionary[key];
                bool removed = values.Remove(value);

                // If the list is empty after removal, remove the key
                if (values.Count == 0)
                {
                    _dictionary.Remove(key);
                }

                return removed;
            }
            return false;
        }

        // Remove a key and all its associated values
        public bool RemoveKey(TKey key)
        {
            return _dictionary.Remove(key);
        }

        // Get all values associated with a key
        public IEnumerable<TValue> Get(TKey key)
        {
            if (_dictionary.ContainsKey(key))
            {
                return _dictionary[key];
            }
            throw new KeyNotFoundException($"The key '{key}' was not found.");
        }

        // Check if the dictionary contains a specific key
        public bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        // Implementing IEnumerable<KeyValuePair<K, IEnumerable<V>>> for iteration
        public IEnumerator<KeyValuePair<TKey, IEnumerable<TValue>>> GetEnumerator()
        {
            foreach (var kvp in _dictionary)
            {
                yield return new KeyValuePair<TKey, IEnumerable<TValue>>(kvp.Key, kvp.Value);
            }
        }

        // Non-generic IEnumerable implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    [TestClass]
    public class IMultiValueDictionaryTestClass
    {
        [TestMethod]
        public void IMultiValueDictionaryTest()
        {
            IMultiValueDictionary<string, int> multiValueDict = new DictionaryMultipleValue<string, int>();

            // Add values to the dictionary
            multiValueDict.Add("A", 1);
            multiValueDict.Add("A", 2);
            multiValueDict.Add("B", 3);
            multiValueDict.Add("C", 4);
            multiValueDict.Add("C", 5);

            // Iterate over the dictionary
            foreach (var kvp in multiValueDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Values: {string.Join(", ", kvp.Value)}");
            }

            // Remove a specific value
            multiValueDict.Remove("A", 2);
            Console.WriteLine("\nAfter removing value 2 from key 'A':");

            foreach (var kvp in multiValueDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Values: {string.Join(", ", kvp.Value)}");
            }

            // Remove an entire key
            multiValueDict.RemoveKey("B");
            Console.WriteLine("\nAfter removing key 'B':");

            foreach (var kvp in multiValueDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Values: {string.Join(", ", kvp.Value)}");
            }
        }
    }

}