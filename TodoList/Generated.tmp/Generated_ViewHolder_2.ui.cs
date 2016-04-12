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


namespace Storm.Generated
{
	
	
	public class Generated_ViewHolder_2 : Storm.Mvvm.BaseViewHolder
	{
		
		private TextView _generated_field_53;
		
		private ILocalizationService _generated_field_54;
		
		protected TextView Generated_ViewElement_8
		{
			get
			{
				if ((this._generated_field_53 == null))
				{
					this._generated_field_53 = this.View.FindViewById<TextView>(Resource.Id.Generated_ViewElement_8);
				}
				return this._generated_field_53;
			}
		}
		
		protected ILocalizationService Generated_LocalizationService
		{
			get
			{
				if ((this._generated_field_54 == null))
				{
					this._generated_field_54 = DependencyService.Container.Resolve<ILocalizationService>();
				}
				return this._generated_field_54;
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
			BindingObject generated_bindingObject_38 = new BindingObject(this.Generated_ViewElement_8);
			result.Add(generated_bindingObject_38);
			BindingExpression generated_bindingExpression_42 = new BindingExpression("Text", "Name");
			generated_bindingObject_38.AddExpression(generated_bindingExpression_42);
			return result;
		}
	}
}
