using System;
using System.Linq;
using Realms;
using realmcrash.Models;

namespace realmcrash.Services
{
    public class DataStore
    {
        private readonly Realm _realm;
        public static readonly RealmConfiguration _config = new RealmConfiguration("realmcrash.realm");

        public DataStore()
        {
            _realm = Realm.GetInstance(_config);
        }

        ~DataStore()
        {
            _realm.Dispose();
        }

        public IQueryable<Folder> Folders => _realm.All<Folder>();

        public void Reset()
        {
            _realm.Write(() => _realm.RemoveAll());
        }

        public void Seed()
        {
            _realm.Write(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    var folder = new Folder
                    {
                        Id = Guid.NewGuid().ToString("N"),
                        Title = $"Folder {i + 1}",
                    };
                    for (int j = 0; j < 10; j++)
                    {
                        var item = new Item
                        {
                            Id = Guid.NewGuid().ToString("N"),
                            Title = $"Item {j + 1}",
                        };
                        folder.Items.Add(item);
                    }
                    _realm.Add(folder);
                }
            });
        }

        public void Remove<T>(T obj) where T : RealmObject
        {
            using (var trans = _realm.BeginWrite())
            {
                _realm.Remove(obj);
                trans.Commit();
            }
        }

        public T Find<T>(string primaryKey) where T : RealmObject
        {
            return _realm.Find<T>(primaryKey);
        }

        public void Write(Action action)
        {
            _realm.Write(action);
        }
    }
}