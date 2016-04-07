//------------------------------------------------------------------------------
// This file was generated by binding preprocessing system for Android
//------------------------------------------------------------------------------

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Storm.Generated;
using Storm.Mvvm;
using Storm.Mvvm.Bindings;
using Storm.Mvvm.Components;
using Storm.Mvvm.Inject;
using Storm.Mvvm.Services;
using Storm.Mvvm.TemplateSelectors;
using System;
using System.Collections.Generic;
using System.Reflection;
using TodoList;


namespace TodoList.Activities
{
	
	
	public partial class DisplayActivity
	{
		
		private ListView _generated_field_20;
		
		private RelativeLayout _generated_field_21;
		
		private Button _generated_field_22;
		
		private ILocalizationService _generated_field_23;
		
		protected ListView listView
		{
			get
			{
				if ((this._generated_field_20 == null))
				{
					this._generated_field_20 = this.FindViewById<ListView>(Resource.Id.listView);
				}
				return this._generated_field_20;
			}
		}
		
		protected RelativeLayout InnerRelativeLayout
		{
			get
			{
				if ((this._generated_field_21 == null))
				{
					this._generated_field_21 = this.FindViewById<RelativeLayout>(Resource.Id.InnerRelativeLayout);
				}
				return this._generated_field_21;
			}
		}
		
		protected Button add
		{
			get
			{
				if ((this._generated_field_22 == null))
				{
					this._generated_field_22 = this.FindViewById<Button>(Resource.Id.add);
				}
				return this._generated_field_22;
			}
		}
		
		protected ILocalizationService Generated_LocalizationService
		{
			get
			{
				if ((this._generated_field_23 == null))
				{
					this._generated_field_23 = DependencyService.Container.Resolve<ILocalizationService>();
				}
				return this._generated_field_23;
			}
		}
		
		private void Generated_AssignTranslation()
		{
		}
		
		private void Generated_AssignResourceForResource()
		{
		}
		
		private void Generated_AssignResourceForView()
		{
		}
		
		protected override List<BindingObject> GetBindingPaths()
		{
			this.Generated_AssignTranslation();
			this.Generated_AssignResourceForResource();
			this.Generated_AssignResourceForView();
			List<BindingObject> result = new List<BindingObject>();
			return result;
		}
	}
}
