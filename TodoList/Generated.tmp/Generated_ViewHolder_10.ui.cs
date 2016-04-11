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
	
	
	public class Generated_ViewHolder_10 : Storm.Mvvm.BaseViewHolder
	{
		
		private TextView _generated_field_170;
		
		private ILocalizationService _generated_field_171;
		
		protected TextView Generated_ViewElement_32
		{
			get
			{
				if ((this._generated_field_170 == null))
				{
					this._generated_field_170 = this.View.FindViewById<TextView>(Resource.Id.Generated_ViewElement_32);
				}
				return this._generated_field_170;
			}
		}
		
		protected ILocalizationService Generated_LocalizationService
		{
			get
			{
				if ((this._generated_field_171 == null))
				{
					this._generated_field_171 = DependencyService.Container.Resolve<ILocalizationService>();
				}
				return this._generated_field_171;
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
			BindingObject generated_bindingObject_110 = new BindingObject(this.Generated_ViewElement_32);
			result.Add(generated_bindingObject_110);
			BindingExpression generated_bindingExpression_122 = new BindingExpression("Text", "Name");
			generated_bindingObject_110.AddExpression(generated_bindingExpression_122);
			return result;
		}
	}
}