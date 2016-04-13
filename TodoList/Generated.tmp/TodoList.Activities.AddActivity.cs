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
	
	
	public partial class AddActivity
	{
		
		private EditText _generated_field_190;
		
		private EditText _generated_field_191;
		
		private Button _generated_field_192;
		
		private ILocalizationService _generated_field_193;
		
		protected EditText name
		{
			get
			{
				if ((this._generated_field_190 == null))
				{
					this._generated_field_190 = this.FindViewById<EditText>(Resource.Id.name);
				}
				return this._generated_field_190;
			}
		}
		
		protected EditText descitption
		{
			get
			{
				if ((this._generated_field_191 == null))
				{
					this._generated_field_191 = this.FindViewById<EditText>(Resource.Id.descitption);
				}
				return this._generated_field_191;
			}
		}
		
		protected Button save
		{
			get
			{
				if ((this._generated_field_192 == null))
				{
					this._generated_field_192 = this.FindViewById<Button>(Resource.Id.save);
				}
				return this._generated_field_192;
			}
		}
		
		protected ILocalizationService Generated_LocalizationService
		{
			get
			{
				if ((this._generated_field_193 == null))
				{
					this._generated_field_193 = DependencyService.Container.Resolve<ILocalizationService>();
				}
				return this._generated_field_193;
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
			BindingObject generated_bindingObject_136 = new BindingObject(this.name);
			result.Add(generated_bindingObject_136);
			BindingExpression generated_bindingExpression_150 = new BindingExpression("Text", "Title");
			generated_bindingExpression_150.Mode = BindingMode.TwoWay;
			generated_bindingExpression_150.UpdateEvent = "TextChanged";
			generated_bindingObject_136.AddExpression(generated_bindingExpression_150);
			BindingObject generated_bindingObject_137 = new BindingObject(this.descitption);
			result.Add(generated_bindingObject_137);
			BindingExpression generated_bindingExpression_151 = new BindingExpression("Text", "Description");
			generated_bindingExpression_151.Mode = BindingMode.TwoWay;
			generated_bindingExpression_151.UpdateEvent = "TextChanged";
			generated_bindingObject_137.AddExpression(generated_bindingExpression_151);
			BindingObject generated_bindingObject_138 = new BindingObject(this.save);
			result.Add(generated_bindingObject_138);
			BindingExpression generated_bindingExpression_152 = new BindingExpression("Click", "ButtonSave");
			generated_bindingObject_138.AddExpression(generated_bindingExpression_152);
			return result;
		}
	}
}
