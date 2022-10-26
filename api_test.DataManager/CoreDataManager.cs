using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_test.DataManager
{
    public class CoreDataManager : DataManager
    {
        public override void Seed() => InjectAllData();

        public async void InjectAllData()
        {
            
        }
    }
}
