﻿using System;
using System.Collections.Generic;
using WebVella.ERP.Storage;
using WebVella.ERP.Api;
using MongoDB.Bson.Serialization.Attributes;
using WebVella.ERP.Api.Models;

namespace WebVella.ERP.Storage.Mongo
{
	public class MongoRecordList : IStorageRecordList
	{
		[BsonElement("id")]
		public Guid Id { get; set; }

		[BsonElement("name")]
		public string Name { get; set; }

		[BsonElement("label")]
		public string Label { get; set; }

		[BsonElement("default")]
		public bool? Default { get; set; }

		[BsonElement("system")]
		public bool? System { get; set; }

		[BsonElement("weight")]
		public decimal? Weight { get; set; }

		[BsonElement("cssClass")]
		public string CssClass { get; set; }

		[BsonElement("type")]
		public RecordListType Type { get; set; }

		[BsonElement("recordsLimit")]
		public int RecordsLimit { get; set; }

		[BsonElement("pageSize")]
		public int PageSize { get; set; }

		[BsonElement("columns")]
		public List<IStorageRecordListItemBase> Columns { get; set; }

		[BsonElement("query")]
		public IStorageRecordListQuery Query { get; set; }

		[BsonElement("sorts")]
		public List<IStorageRecordListSort> Sorts { get; set; }
	}

	public class MongoRecordListQuery : IStorageRecordListQuery
	{
		[BsonElement("queryType")]
		public QueryType QueryType { get; set; }

		[BsonElement("fieldName")]
		public string FieldName { get; set; }

		[BsonElement("fieldValue")]
		public string FieldValue { get; set; }

		[BsonElement("subQueries")]
		public List<IStorageRecordListQuery> SubQueries { get; set; }
	}

	public class MongoRecordListSort : IStorageRecordListSort
	{
		[BsonElement("fieldName")]
		public string FieldName { get; set; }

		[BsonElement("sortType")]
		public QuerySortType SortType { get; set; }
	}

	public abstract class MongoRecordListItemBase : IStorageRecordListItemBase
	{
	}

	public class MongoRecordListFieldItem : MongoRecordListItemBase, IStorageRecordListFieldItem
	{
		[BsonElement("fieldId")]
		public Guid FieldId { get; set; }
	}

	public class MongoRecordListRelationFieldItem : MongoRecordListItemBase, IStorageRecordListRelationFieldItem
	{
		[BsonElement("relationId")]
		public Guid RelationId { get; set; }

		[BsonElement("entityId")]
		public Guid EntityId { get; set; }

		[BsonElement("fieldId")]
		public Guid FieldId { get; set; }
	}
}