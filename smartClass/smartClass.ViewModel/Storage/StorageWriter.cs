using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartClass.Model;
using Windows.Storage;

namespace smartClass.ViewModel.Storage
{
    public class StorageWriter
    {
        private ApplicationDataContainer storage;

        public StorageWriter()
        {
            storage = ApplicationData.Current.RoamingSettings;
        }

        public Task WriteClassAsync(MClass item)
        {
            return Task.Run(() =>
            {
                ApplicationDataContainer cclass = storage.CreateContainer("Class", ApplicationDataCreateDisposition.Always);
                cclass.CreateContainer(item.ID.ToString(), ApplicationDataCreateDisposition.Always).Values.Add("Name", item.Name);

            });
        }
    }
}
