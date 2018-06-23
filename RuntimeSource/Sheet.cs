using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace geniikw.DataSheetLab
{
    public abstract class SheetBase : ScriptableObject{ }
    
    public class ReferSheet<TSheet, TItem> : IEnumerable<TItem>  where TSheet : Sheet<TItem>
    {
        public TSheet Sheet;
        public List<int> idxList;

        public TItem this[int idx] {
            get
            {
                return Sheet[idxList[idx]];
            }
        }
        
        public IEnumerator<TItem> GetEnumerator()
        {
            foreach (var idx in idxList)
                yield return Sheet[idx];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Sheet<T> : SheetBase , IEnumerable<T>
    {
        public List<T> data = new List<T>();

        public T this[int index]
        {
            get
            {
                return data[index];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in data)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
