using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

public class CustomNoSqlDb
{
    private readonly string _databasePath;

    public CustomNoSqlDb(string databasePath)
    {
        _databasePath = databasePath;
        if (!Directory.Exists(_databasePath))
        {
            Directory.CreateDirectory(_databasePath);
        }
    }

    private string GetCollectionPath(string collectionName) => Path.Combine(_databasePath, $"{collectionName}.json");

    private Dictionary<Guid, string> LoadCollection(string collectionName)
    {
        var collectionPath = GetCollectionPath(collectionName);
        if (!File.Exists(collectionPath))
        {
            return new Dictionary<Guid, string>();
        }

        var json = File.ReadAllText(collectionPath);
        return JsonConvert.DeserializeObject<Dictionary<Guid, string>>(json);
    }

    private void SaveCollection(string collectionName, Dictionary<Guid, string> collection)
    {
        var collectionPath = GetCollectionPath(collectionName);
        var json = JsonConvert.SerializeObject(collection, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(collectionPath, json);
    }

    public void Insert<T>(T document, string collectionName)
    {
        var collection = LoadCollection(collectionName);
        var id = Guid.NewGuid();
        var json = JsonConvert.SerializeObject(document);
        collection[id] = json;
        SaveCollection(collectionName, collection);
    }

    public T GetById<T>(Guid id, string collectionName)
    {
        var collection = LoadCollection(collectionName);
        if (collection.TryGetValue(id, out var json))
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
        return default(T);
    }

    public void Update<T>(Guid id, T document, string collectionName)
    {
        var collection = LoadCollection(collectionName);
        var json = JsonConvert.SerializeObject(document);
        collection[id] = json;
        SaveCollection(collectionName, collection);
    }

    public void Delete(Guid id, string collectionName)
    {
        var collection = LoadCollection(collectionName);
        if (collection.Remove(id))
        {
            SaveCollection(collectionName, collection);
        }
    }

    public IEnumerable<T> GetAll<T>(string collectionName)
    {
        var collection = LoadCollection(collectionName);
        foreach (var json in collection.Values)
        {
            yield return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
