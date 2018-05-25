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
	/// <summary>Medarbejdere</summary>
	[PublishedContentModel("medarbejdere")]
	public partial class Medarbejdere : PublishedContentModel, IBaseContent, IHeroHeader
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "medarbejdere";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Medarbejdere(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Medarbejdere, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Arbejder af LVS
		///</summary>
		[ImplementPropertyType("arbejderAfLVS")]
		public IEnumerable<IPublishedContent> ArbejderAfLvs
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("arbejderAfLVS"); }
		}

		///<summary>
		/// Grid list
		///</summary>
		[ImplementPropertyType("gridList")]
		public IEnumerable<IPublishedContent> GridList
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("gridList"); }
		}

		///<summary>
		/// Headline2
		///</summary>
		[ImplementPropertyType("headline2")]
		public string Headline2
		{
			get { return this.GetPropertyValue<string>("headline2"); }
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return Umbraco.Web.PublishedContentModels.BaseContent.GetContent(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.BaseContent.GetHeadline(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("heroHeadline")]
		public string HeroHeadline
		{
			get { return Umbraco.Web.PublishedContentModels.HeroHeader.GetHeroHeadline(this); }
		}

		///<summary>
		/// Background Image
		///</summary>
		[ImplementPropertyType("heroImage")]
		public IPublishedContent HeroImage
		{
			get { return Umbraco.Web.PublishedContentModels.HeroHeader.GetHeroImage(this); }
		}
	}
}
