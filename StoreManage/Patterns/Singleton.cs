
using StoreManage.Models.Factory;
using StoreManage.Models.Interface;
﻿using StoreManage.Models;

namespace StoreManage.Patterns
{
    internal class Singleton
    {
        private static Singleton _instance;
        private List<Store> _stores;

        private Singleton()
        {
            _stores = new List<Store>();
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void AddStore(Store store)
        {
            _stores.Add(store);
        }

        public List<Store> GetStores()
        {
            return _stores;
        }

    }
}
