using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personenregister.Data
{
    public class RegistryService
    {
        private static List<RegistryC> mockDB = new List<RegistryC>()
        {
            new RegistryC(){Name="Hammett", PreName="Kirk", Age=60, Summary="Hi"}
        };

        public async Task<bool> AddRegistry(RegistryC newReg)
        {
            mockDB.Add(newReg);
            return true;
        }
        public async Task<List<RegistryC>> GetRegistry()
        {
            return mockDB;
        }

        public async Task<bool> DeleteRegistry(RegistryC newReg)
        {
            RegistryC registryToDelete = mockDB.FirstOrDefault(reg => reg.Name == newReg.Name && reg.PreName == newReg.PreName);
            if (registryToDelete != null)
            {
                mockDB.Remove(registryToDelete);
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateRegistry(RegistryC newReg)
        {
            RegistryC registryToDelete = mockDB.FirstOrDefault(reg => reg.Name == newReg.Name && reg.PreName == newReg.PreName);
            if (registryToDelete != null)
            {
                mockDB.Remove(registryToDelete);
                mockDB.Add(newReg);
                return true;
            }
            return false;
        }
    }
}
