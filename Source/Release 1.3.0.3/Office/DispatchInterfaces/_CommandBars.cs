//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface _CommandBars SupportByLibraryAttribute Office, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _CommandBars : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.CommandBar>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_CommandBars);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CommandBars(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CommandBars(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CommandBars(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CommandBars() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CommandBars(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl ActionControl
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActionControl", paramsArray);
				NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBarControl;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar ActiveMenuBar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveMenuBar", paramsArray);
				NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public bool DisplayTooltips
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayTooltips", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayTooltips", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public bool DisplayKeysInTooltips
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayKeysInTooltips", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayKeysInTooltips", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.CommandBar this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public bool LargeButtons
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LargeButtons", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LargeButtons", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoMenuAnimation MenuAnimationStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MenuAnimationStyle", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoMenuAnimation)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MenuAnimationStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="ids">Int32 ids</param>
		/// <param name="pbstrName">string pbstrName</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public Int32 get_IdsString(Int32 ids, out string pbstrName)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			pbstrName = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(ids, pbstrName);
			object returnItem = Invoker.PropertyGet(this, "IdsString", paramsArray);
			pbstrName = (string)paramsArray[1];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="tmc">Int32 tmc</param>
		/// <param name="pbstrName">string pbstrName</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public Int32 get_TmcGetName(Int32 tmc, out string pbstrName)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			pbstrName = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(tmc, pbstrName);
			object returnItem = Invoker.PropertyGet(this, "TmcGetName", paramsArray);
			pbstrName = (string)paramsArray[1];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public bool AdaptiveMenus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AdaptiveMenus", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AdaptiveMenus", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public bool DisplayFonts
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayFonts", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayFonts", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public bool DisableCustomize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisableCustomize", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisableCustomize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public bool DisableAskAQuestionDropdown
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisableAskAQuestionDropdown", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisableAskAQuestionDropdown", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Position">optional object Position</param>
		/// <param name="MenuBar">optional object MenuBar</param>
		/// <param name="Temporary">optional object Temporary</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar Add(object name, object position, object menuBar, object temporary)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, position, menuBar, temporary);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">optional object Name</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar Add(object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Position">optional object Position</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar Add(object name, object position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, position);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Position">optional object Position</param>
		/// <param name="MenuBar">optional object MenuBar</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar Add(object name, object position, object menuBar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, position, menuBar);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Id">optional object Id</param>
		/// <param name="Tag">optional object Tag</param>
		/// <param name="Visible">optional object Visible</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl FindControl(object type, object id, object tag, object visible)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, id, tag, visible);
			object returnItem = Invoker.MethodReturn(this, "FindControl", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl FindControl()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "FindControl", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">optional object Type</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl FindControl(object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "FindControl", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Id">optional object Id</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl FindControl(object type, object id)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, id);
			object returnItem = Invoker.MethodReturn(this, "FindControl", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Id">optional object Id</param>
		/// <param name="Tag">optional object Tag</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl FindControl(object type, object id, object tag)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, id, tag);
			object returnItem = Invoker.MethodReturn(this, "FindControl", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void ReleaseFocus()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ReleaseFocus", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Id">optional object Id</param>
		/// <param name="Tag">optional object Tag</param>
		/// <param name="Visible">optional object Visible</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControls FindControls(object type, object id, object tag, object visible)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, id, tag, visible);
			object returnItem = Invoker.MethodReturn(this, "FindControls", paramsArray);
			NetOffice.OfficeApi.CommandBarControls newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBarControls.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBarControls;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControls FindControls()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "FindControls", paramsArray);
			NetOffice.OfficeApi.CommandBarControls newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBarControls.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBarControls;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">optional object Type</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControls FindControls(object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "FindControls", paramsArray);
			NetOffice.OfficeApi.CommandBarControls newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBarControls.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBarControls;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Id">optional object Id</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControls FindControls(object type, object id)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, id);
			object returnItem = Invoker.MethodReturn(this, "FindControls", paramsArray);
			NetOffice.OfficeApi.CommandBarControls newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBarControls.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBarControls;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Id">optional object Id</param>
		/// <param name="Tag">optional object Tag</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControls FindControls(object type, object id, object tag)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, id, tag);
			object returnItem = Invoker.MethodReturn(this, "FindControls", paramsArray);
			NetOffice.OfficeApi.CommandBarControls newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBarControls.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBarControls;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="TbidOrName">optional object TbidOrName</param>
		/// <param name="Position">optional object Position</param>
		/// <param name="MenuBar">optional object MenuBar</param>
		/// <param name="Temporary">optional object Temporary</param>
		/// <param name="TbtrProtection">optional object TbtrProtection</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar AddEx(object tbidOrName, object position, object menuBar, object temporary, object tbtrProtection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tbidOrName, position, menuBar, temporary, tbtrProtection);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar AddEx()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="TbidOrName">optional object TbidOrName</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar AddEx(object tbidOrName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tbidOrName);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="TbidOrName">optional object TbidOrName</param>
		/// <param name="Position">optional object Position</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar AddEx(object tbidOrName, object position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tbidOrName, position);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="TbidOrName">optional object TbidOrName</param>
		/// <param name="Position">optional object Position</param>
		/// <param name="MenuBar">optional object MenuBar</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar AddEx(object tbidOrName, object position, object menuBar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tbidOrName, position, menuBar);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="TbidOrName">optional object TbidOrName</param>
		/// <param name="Position">optional object Position</param>
		/// <param name="MenuBar">optional object MenuBar</param>
		/// <param name="Temporary">optional object Temporary</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar AddEx(object tbidOrName, object position, object menuBar, object temporary)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tbidOrName, position, menuBar, temporary);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CommandBar.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBar;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="idMso">string idMso</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void ExecuteMso(string idMso)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(idMso);
			Invoker.Method(this, "ExecuteMso", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="idMso">string idMso</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public bool GetEnabledMso(string idMso)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(idMso);
			object returnItem = Invoker.MethodReturn(this, "GetEnabledMso", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="idMso">string idMso</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public bool GetVisibleMso(string idMso)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(idMso);
			object returnItem = Invoker.MethodReturn(this, "GetVisibleMso", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="idMso">string idMso</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public bool GetPressedMso(string idMso)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(idMso);
			object returnItem = Invoker.MethodReturn(this, "GetPressedMso", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="idMso">string idMso</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public string GetLabelMso(string idMso)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(idMso);
			object returnItem = Invoker.MethodReturn(this, "GetLabelMso", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="idMso">string idMso</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public string GetScreentipMso(string idMso)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(idMso);
			object returnItem = Invoker.MethodReturn(this, "GetScreentipMso", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="idMso">string idMso</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public string GetSupertipMso(string idMso)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(idMso);
			object returnItem = Invoker.MethodReturn(this, "GetSupertipMso", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="idMso">string idMso</param>
		/// <param name="Width">Int32 Width</param>
		/// <param name="Height">Int32 Height</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public stdole.Picture GetImageMso(string idMso, Int32 width, Int32 height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(idMso, width, height);
			object returnItem = Invoker.MethodReturn(this, "GetImageMso", paramsArray);
			stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as stdole.Picture;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		/// <param name="hwnd">Int32 hwnd</param>
		[SupportByLibraryAttribute("Office", 14)]
		public void CommitRenderingTransaction(Int32 hwnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hwnd);
			Invoker.Method(this, "CommitRenderingTransaction", paramsArray);
		}

		#endregion

        #region IEnumerable<NetOffice.OfficeApi.CommandBar> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Office, 9,10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
        public IEnumerator<NetOffice.OfficeApi.CommandBar> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OfficeApi.CommandBar item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Office, 9,10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}