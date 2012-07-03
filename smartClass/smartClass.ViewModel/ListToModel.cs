using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartClass.Model;

namespace smartClass.ViewModel
{
    public class ListToModel : IList<IVMBase>, INotifyPropertyChanged, INotifyCollectionChanged
    {
        private IList<IVMBase> _list;
        private IList<IMBase> _baselist;

        public ListToModel(IList<IMBase> Baselist)
        {
            this._baselist = Baselist;
            this._list = new List<IVMBase>();
            foreach (IMBase item in _baselist)
            {

            }
        }

        #region IList<IVMBase>
        public int IndexOf(IVMBase item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, IVMBase item)
        {
            NotifyCollectionChangedAction action;
            IVMBase olditem = null;
            if (_list[index] == null)
            {
                action = NotifyCollectionChangedAction.Add;
            }
            else
            {
                action = NotifyCollectionChangedAction.Replace;
                olditem = _list[index];
            }
            _list.Insert(index, item);

            if (action == NotifyCollectionChangedAction.Replace)
            {
                RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, olditem, index));
            }
            else
            {
                RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, index));
            }

            _baselist.Insert(index, item.Model);
        }

        public void RemoveAt(int index)
        {
            IVMBase item = _list[index];
            _list.RemoveAt(index);
            RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
            _baselist.RemoveAt(index);
        }

        public IVMBase this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                NotifyCollectionChangedAction action = _list[index] == null ? NotifyCollectionChangedAction.Add : NotifyCollectionChangedAction.Replace;
                _list[index] = value;
                RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(action, 
                _baselist[index] = value.Model;
            }
        }

        public void Add(IVMBase item)
        {
            _list.Add(item);
            RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            _baselist.Add(item.Model);
        }

        public void Clear()
        {
            _list.Clear();
            RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            _baselist.Clear();
        }

        public bool Contains(IVMBase item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(IVMBase[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public bool IsReadOnly
        {
            get { return _list.IsReadOnly; }
        }

        public bool Remove(IVMBase item)
        {
            bool ItemFound = _list.Remove(item);
            if (ItemFound)
            {
                RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
                _baselist.Remove(item.Model);
            }
            return ItemFound;
        }

        public IEnumerator<IVMBase> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        #region INotifyPropertyChanged
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region INotifyCollectionChanged
        protected virtual void RaiseCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            if (CollectionChanged != null)
            {
                CollectionChanged(this, args);
            }
        }
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        #endregion
    }
}
