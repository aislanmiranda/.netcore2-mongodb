using a82.Domain;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections.Generic;

namespace a82.Data.Mongo
{
    public class Repository<T>
    {
        private string _collectionName { get; set; }
        private static IMongoClient _client;
        private static IMongoDatabase _database;
        private IMongoCollection<T> _collection;

        public Repository(string collectionName)
        {
            this._collectionName = collectionName;
            string connectionString = Settings.MongoConnection;
            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            _client = new MongoClient(settings);
            _database = _client.GetDatabase(Settings.Database);
            _collection = _database.GetCollection<T>(this._collectionName);
        }
        protected T Insert(T obj)
        {
            this._collection.InsertOne(obj);
            return this.Get((obj as MongoEntity)._id);
        }

        protected List<T> SelectAll()
        {
            return this._collection.Find(new BsonDocument()).ToList();
        }

        protected List<T> Filter(string jsonQuery)
        {
            var queryDoc = BsonSerializer.Deserialize<BsonDocument>(jsonQuery);
            return _collection.Find<T>(queryDoc).ToList();
        }

        protected T Get(string id)
        {
            var filter = Builders<T>.Filter.Eq("_id", new ObjectId(id));
            var result = _collection.Find(filter).FirstOrDefault();
            return result;
        }

        protected T Get(ObjectId id)
        {
            return this._collection.Find(new BsonDocument { { "_id", id } }).FirstAsync().Result;
        }
        protected T Update(string id, T obj)
        {
            (obj as MongoEntity)._id = id;

            var filter = Builders<T>.Filter.Eq(s => (s as MongoEntity)._id, (obj as MongoEntity)._id);
            this._collection.ReplaceOneAsync(filter, obj);
            return this.Get(id);
        }

        protected bool Remove(string id)
        {
            var filter = Builders<T>.Filter.Eq(s => (s as MongoEntity)._id, id);
            var result = this._collection.DeleteOne(filter);
            return result.DeletedCount == 1;
        }

    }
}
