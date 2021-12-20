using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class DataStorage
    {
        private string _pathToStorage;
        private const string _accountsFileName = "acconts.txt";
        private const string _gamesFileName = "games.txt";

        public DataStorage(string pathToStorage)
        {
            _pathToStorage = pathToStorage;
            if (!Directory.Exists(_pathToStorage))
            {
                Directory.CreateDirectory(_pathToStorage);
            }
        }

        public void Save(List<Account> accounts)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(_pathToStorage, _accountsFileName),false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(accounts));
            }
        }

        public void Save(List<Game> games)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(_pathToStorage, _gamesFileName),false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(games));
            }
        }

        public void Save(List<Account> accounts, List<Game> games)
        {
            Save(accounts);
            Save(games);
        }

        private void Load(out List<Account> accounts)
        {
            string st = Path.Combine(_pathToStorage, _accountsFileName);

            if (File.Exists(st))
            {
                using (StreamReader sr = new StreamReader(Path.Combine(_pathToStorage, _accountsFileName)))
                {
                    accounts = JsonConvert.DeserializeObject<List<Account>>(sr.ReadToEnd());
                    if (accounts==null)
                    {
                accounts = new List<Account>();
                    }
                }
            }
            else
            {
                accounts = new List<Account>();
            }
        }

        private void Load(out List<Game> games)
        {
            string st = Path.Combine(_pathToStorage, _gamesFileName);

            if (File.Exists(st))
            {

                using (StreamReader sr = new StreamReader(Path.Combine(_pathToStorage, _gamesFileName)))
                {
                    games = JsonConvert.DeserializeObject<List<Game>>(sr.ReadToEnd());
                }
            }
            else
            {
                games = new List<Game>();
            }
        }

        public void Load(out List<Account> accounts, out List<Game> games)
        {
            Load(out accounts);
            Load(out games);
        }
    }
}
