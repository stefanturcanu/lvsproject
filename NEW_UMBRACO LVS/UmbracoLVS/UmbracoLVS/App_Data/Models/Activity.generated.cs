//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Activity</summary>
	[PublishedContentModel("activity")]
	public partial class Activity : PublishedContentModel, IItem, ILocation
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "activity";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Activity(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Activity, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Activity Category
		///</summary>
		[ImplementPropertyType("activityCategory")]
		public string ActivityCategory
		{
			get { return this.GetPropertyValue<string>("activityCategory"); }
		}

		///<summary>
		/// End Date
		///</summary>
		[ImplementPropertyType("endDate")]
		public DateTime EndDate
		{
			get { return this.GetPropertyValue<DateTime>("endDate"); }
		}

		///<summary>
		/// Start Date
		///</summary>
		[ImplementPropertyType("startDate")]
		public DateTime StartDate
		{
			get { return this.GetPropertyValue<DateTime>("startDate"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public IHtmlString Description
		{
			get { return Umbraco.Web.PublishedContentModels.Item.GetDescription(this); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return Umbraco.Web.PublishedContentModels.Item.GetImage(this); }
		}

		///<summary>
		/// Address
		///</summary>
		[ImplementPropertyType("address")]
		public string Address
		{
			get { return Umbraco.Web.PublishedContentModels.Location.GetAddress(this); }
		}

		///<summary>
		/// City
		///</summary>
		[ImplementPropertyType("city")]
		public string City
		{
			get { return Umbraco.Web.PublishedContentModels.Location.GetCity(this); }
		}

		///<summary>
		/// GPScoordinates
		///</summary>
		[ImplementPropertyType("gPScoordinates")]
		public string GPscoordinates
		{
			get { return Umbraco.Web.PublishedContentModels.Location.GetGPscoordinates(this); }
		}

		///<summary>
		/// PostCode
		///</summary>
		[ImplementPropertyType("postCode")]
		public int PostCode
		{
			get { return Umbraco.Web.PublishedContentModels.Location.GetPostCode(this); }
		}
	}
}
