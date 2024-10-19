using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureMSTest.InterviewQuestions
{
    public class DictionaryMultipleValue<TKey, TValue>
    {
        private Dictionary<TKey, List<TValue>> _dictionary;

        DictionaryMultipleValue(TKey key, TValue value)
        {
            _dictionary = new Dictionary<TKey, List<TValue>>();
        }

    }
}
