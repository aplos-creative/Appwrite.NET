using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Interfaces
{
	public interface IDatabaseService
	{
		Task<CollectionsList> ListCollections(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task<Collection> CreateCollection(string name, List<object> read, List<object> write, List<object> rules);
		Task<Collection> GetCollection(string collectionId);
		Task<Collection> UpdateCollection(string collectionId, string name, List<object> read, List<object> write, List<object> rules = null);
		Task DeleteCollection(string collectionId);
		Task<DocumentsList> ListDocuments(string collectionId, List<object> filters = null, int? limit = 25, int? offset = 0, string orderField = "", OrderType orderType = OrderType.ASC, string orderCast = "string", string search = "");
		Task<Document> CreateDocument(string collectionId, object data, List<object> read, List<object> write, string parentDocument = "", string parentProperty = "", string parentPropertyType = "assign");
		Task<Document> GetDocument(string collectionId, string documentId);
		Task<Document> UpdateDocument(string collectionId, string documentId, object data, List<object> read, List<object> write);
		Task DeleteDocument(string collectionId, string documentId);
	}
}
