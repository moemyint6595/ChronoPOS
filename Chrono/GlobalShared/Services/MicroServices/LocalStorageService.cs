﻿using Microsoft.JSInterop;
using System.Text.Json;

namespace GlobalShared.Services.MicroServices
{
    public interface ILocalStorage
    {
        Task<T?> GetItem<T>(string key);
        Task SetItem<T>(string key, T? value);
        Task RemoveItem(string key);
        Task Clear();
    }
    public class LocalStorageService(IJSRuntime jSRuntime) : ILocalStorage
    {
        IJSRuntime _jSRuntime = jSRuntime;

        public async Task<T?> GetItem<T>(string key)
        {
            var json = await _jSRuntime.InvokeAsync<string>("localStorage.getItem", key);
            if (json is null) return default;
            return JsonSerializer.Deserialize<T>(json);
        }

        public async Task SetItem<T>(string key, T? value)
        {
            var json = JsonSerializer.Serialize(value);
            await _jSRuntime.InvokeVoidAsync("localStorage.setItem", key, json);
        }

        public async Task RemoveItem(string key)
        {
            await _jSRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        }
        public async Task Clear()
        {
            await _jSRuntime.InvokeVoidAsync("localStorage.clear");
        }
    }
}
