using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestXamarin.Models;
using Xamarin.Forms;

namespace TestXamarin.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            ImageSource i = ImageSource.FromFile("acne.jpg");
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "21.02.2020", Description="60", Photo= i},
                new Item { Id = Guid.NewGuid().ToString(), Text = "22.02.2020", Description="40", Photo= i },
                new Item { Id = Guid.NewGuid().ToString(), Text = "23.02.2020", Description="55", Photo= i }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}