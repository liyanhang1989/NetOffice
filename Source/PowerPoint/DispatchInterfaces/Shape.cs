﻿using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Shape 
	/// SupportByVersion PowerPoint, 9,10,11,12,14,15,16
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744177.aspx
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Shape : COMObject
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
                    _type = typeof(Shape);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Shape(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746546.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public object Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				ICOMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745320.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745882.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				ICOMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744335.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Adjustments Adjustments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Adjustments", paramsArray);
				NetOffice.PowerPointApi.Adjustments newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Adjustments.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Adjustments;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745730.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoAutoShapeType AutoShapeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoShapeType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoAutoShapeType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoShapeType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746135.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoBlackWhiteMode BlackWhiteMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BlackWhiteMode", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoBlackWhiteMode)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BlackWhiteMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744566.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.CalloutFormat Callout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Callout", paramsArray);
				NetOffice.PowerPointApi.CalloutFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.CalloutFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.CalloutFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744215.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public Int32 ConnectionSiteCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConnectionSiteCount", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744646.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState Connector
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connector", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745185.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.ConnectorFormat ConnectorFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConnectorFormat", paramsArray);
				NetOffice.PowerPointApi.ConnectorFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ConnectorFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ConnectorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746145.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.FillFormat Fill
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fill", paramsArray);
				NetOffice.PowerPointApi.FillFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.FillFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.FillFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744300.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.GroupShapes GroupItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GroupItems", paramsArray);
				NetOffice.PowerPointApi.GroupShapes newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.GroupShapes.LateBindingApiWrapperType) as NetOffice.PowerPointApi.GroupShapes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744642.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public Single Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746137.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState HorizontalFlip
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HorizontalFlip", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744179.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public Single Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746649.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.LineFormat Line
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Line", paramsArray);
				NetOffice.PowerPointApi.LineFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.LineFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.LineFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746019.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState LockAspectRatio
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockAspectRatio", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockAspectRatio", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745119.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745456.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.ShapeNodes Nodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Nodes", paramsArray);
				NetOffice.PowerPointApi.ShapeNodes newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ShapeNodes.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744648.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public Single Rotation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Rotation", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Rotation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745708.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.PictureFormat PictureFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PictureFormat", paramsArray);
				NetOffice.PowerPointApi.PictureFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.PictureFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.PictureFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745432.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.ShadowFormat Shadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shadow", paramsArray);
				NetOffice.PowerPointApi.ShadowFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ShadowFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShadowFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746013.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.TextEffectFormat TextEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextEffect", paramsArray);
				NetOffice.PowerPointApi.TextEffectFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.TextEffectFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.TextEffectFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745204.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.TextFrame TextFrame
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextFrame", paramsArray);
				NetOffice.PowerPointApi.TextFrame newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.TextFrame.LateBindingApiWrapperType) as NetOffice.PowerPointApi.TextFrame;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744099.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.ThreeDFormat ThreeD
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ThreeD", paramsArray);
				NetOffice.PowerPointApi.ThreeDFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ThreeDFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ThreeDFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746310.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public Single Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744590.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoShapeType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoShapeType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744922.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState VerticalFlip
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VerticalFlip", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746065.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public object Vertices
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Vertices", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					ICOMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746143.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746057.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public Single Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff743931.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public Int32 ZOrderPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ZOrderPosition", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746417.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.OLEFormat OLEFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLEFormat", paramsArray);
				NetOffice.PowerPointApi.OLEFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.OLEFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.OLEFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746031.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.LinkFormat LinkFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LinkFormat", paramsArray);
				NetOffice.PowerPointApi.LinkFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.LinkFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.LinkFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744826.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.PlaceholderFormat PlaceholderFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PlaceholderFormat", paramsArray);
				NetOffice.PowerPointApi.PlaceholderFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.PlaceholderFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.PlaceholderFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746259.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.AnimationSettings AnimationSettings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AnimationSettings", paramsArray);
				NetOffice.PowerPointApi.AnimationSettings newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.AnimationSettings.LateBindingApiWrapperType) as NetOffice.PowerPointApi.AnimationSettings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745134.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.ActionSettings ActionSettings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActionSettings", paramsArray);
				NetOffice.PowerPointApi.ActionSettings newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ActionSettings.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ActionSettings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744235.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Tags Tags
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tags", paramsArray);
				NetOffice.PowerPointApi.Tags newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Tags.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Tags;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746194.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Enums.PpMediaType MediaType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MediaType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.PowerPointApi.Enums.PpMediaType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746607.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasTextFrame
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasTextFrame", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.PowerPointApi.SoundFormat SoundFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SoundFormat", paramsArray);
				NetOffice.PowerPointApi.SoundFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.SoundFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SoundFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Script Script
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Script", paramsArray);
				NetOffice.OfficeApi.Script newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.Script.LateBindingApiWrapperType) as NetOffice.OfficeApi.Script;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744026.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public string AlternativeText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlternativeText", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlternativeText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746779.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasTable", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746280.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Table Table
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Table", paramsArray);
				NetOffice.PowerPointApi.Table newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Table.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Table;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasDiagram
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasDiagram", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Diagram Diagram
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Diagram", paramsArray);
				NetOffice.PowerPointApi.Diagram newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Diagram.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Diagram;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasDiagramNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasDiagramNode", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.DiagramNode DiagramNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DiagramNode", paramsArray);
				NetOffice.PowerPointApi.DiagramNode newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DiagramNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744893.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState Child
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Child", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744077.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape ParentGroup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentGroup", paramsArray);
				NetOffice.PowerPointApi.Shape newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.PowerPointApi.CanvasShapes CanvasItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CanvasItems", paramsArray);
				NetOffice.PowerPointApi.CanvasShapes newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.CanvasShapes.LateBindingApiWrapperType) as NetOffice.PowerPointApi.CanvasShapes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746050.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public Int32 Id
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Id", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string RTF
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RTF", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RTF", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746609.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15,16)]
		public NetOffice.PowerPointApi.CustomerData CustomerData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomerData", paramsArray);
				NetOffice.PowerPointApi.CustomerData newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.CustomerData.LateBindingApiWrapperType) as NetOffice.PowerPointApi.CustomerData;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746109.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15,16)]
		public NetOffice.PowerPointApi.TextFrame2 TextFrame2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextFrame2", paramsArray);
				NetOffice.PowerPointApi.TextFrame2 newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.TextFrame2.LateBindingApiWrapperType) as NetOffice.PowerPointApi.TextFrame2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745004.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasChart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasChart", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746055.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoShapeStyleIndex ShapeStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShapeStyle", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoShapeStyleIndex)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShapeStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745547.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoBackgroundStyleIndex BackgroundStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackgroundStyle", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoBackgroundStyleIndex)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackgroundStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746633.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15,16)]
		public NetOffice.OfficeApi.SoftEdgeFormat SoftEdge
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SoftEdge", paramsArray);
				NetOffice.OfficeApi.SoftEdgeFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SoftEdgeFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.SoftEdgeFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744938.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15,16)]
		public NetOffice.OfficeApi.GlowFormat Glow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Glow", paramsArray);
				NetOffice.OfficeApi.GlowFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.GlowFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.GlowFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745046.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15,16)]
		public NetOffice.OfficeApi.ReflectionFormat Reflection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Reflection", paramsArray);
				NetOffice.OfficeApi.ReflectionFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ReflectionFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.ReflectionFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745355.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public NetOffice.PowerPointApi.Chart Chart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Chart", paramsArray);
				NetOffice.PowerPointApi.Chart newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Chart.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Chart;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745668.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasSmartArt
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasSmartArt", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745916.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public NetOffice.OfficeApi.SmartArt SmartArt
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartArt", paramsArray);
				NetOffice.OfficeApi.SmartArt newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SmartArt.LateBindingApiWrapperType) as NetOffice.OfficeApi.SmartArt;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746801.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public string Title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Title", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Title", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746532.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public NetOffice.PowerPointApi.MediaFormat MediaFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MediaFormat", paramsArray);
				NetOffice.PowerPointApi.MediaFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.MediaFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.MediaFormat;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745152.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Apply()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Apply", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745726.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746709.aspx
		/// </summary>
		/// <param name="flipCmd">NetOffice.OfficeApi.Enums.MsoFlipCmd FlipCmd</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Flip(NetOffice.OfficeApi.Enums.MsoFlipCmd flipCmd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(flipCmd);
			Invoker.Method(this, "Flip", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745826.aspx
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void IncrementLeft(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementLeft", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746737.aspx
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void IncrementRotation(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotation", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746032.aspx
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void IncrementTop(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementTop", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744535.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void PickUp()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PickUp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff743943.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void RerouteConnections()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RerouteConnections", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff743874.aspx
		/// </summary>
		/// <param name="factor">Single Factor</param>
		/// <param name="relativeToOriginalSize">NetOffice.OfficeApi.Enums.MsoTriState RelativeToOriginalSize</param>
		/// <param name="fScale">optional NetOffice.OfficeApi.Enums.MsoScaleFrom fScale = 0</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void ScaleHeight(Single factor, NetOffice.OfficeApi.Enums.MsoTriState relativeToOriginalSize, object fScale)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(factor, relativeToOriginalSize, fScale);
			Invoker.Method(this, "ScaleHeight", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff743874.aspx
		/// </summary>
		/// <param name="factor">Single Factor</param>
		/// <param name="relativeToOriginalSize">NetOffice.OfficeApi.Enums.MsoTriState RelativeToOriginalSize</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void ScaleHeight(Single factor, NetOffice.OfficeApi.Enums.MsoTriState relativeToOriginalSize)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(factor, relativeToOriginalSize);
			Invoker.Method(this, "ScaleHeight", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744382.aspx
		/// </summary>
		/// <param name="factor">Single Factor</param>
		/// <param name="relativeToOriginalSize">NetOffice.OfficeApi.Enums.MsoTriState RelativeToOriginalSize</param>
		/// <param name="fScale">optional NetOffice.OfficeApi.Enums.MsoScaleFrom fScale = 0</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void ScaleWidth(Single factor, NetOffice.OfficeApi.Enums.MsoTriState relativeToOriginalSize, object fScale)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(factor, relativeToOriginalSize, fScale);
			Invoker.Method(this, "ScaleWidth", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744382.aspx
		/// </summary>
		/// <param name="factor">Single Factor</param>
		/// <param name="relativeToOriginalSize">NetOffice.OfficeApi.Enums.MsoTriState RelativeToOriginalSize</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void ScaleWidth(Single factor, NetOffice.OfficeApi.Enums.MsoTriState relativeToOriginalSize)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(factor, relativeToOriginalSize);
			Invoker.Method(this, "ScaleWidth", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744782.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void SetShapesDefaultProperties()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetShapesDefaultProperties", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744349.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.ShapeRange Ungroup()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Ungroup", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744516.aspx
		/// </summary>
		/// <param name="zOrderCmd">NetOffice.OfficeApi.Enums.MsoZOrderCmd ZOrderCmd</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void ZOrder(NetOffice.OfficeApi.Enums.MsoZOrderCmd zOrderCmd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(zOrderCmd);
			Invoker.Method(this, "ZOrder", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745620.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744698.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745796.aspx
		/// </summary>
		/// <param name="replace">optional NetOffice.OfficeApi.Enums.MsoTriState Replace = -1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Select(object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(replace);
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745796.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff743989.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.ShapeRange Duplicate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Duplicate", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// 
		/// </summary>
		/// <param name="pathName">string PathName</param>
		/// <param name="filter">NetOffice.PowerPointApi.Enums.PpShapeFormat Filter</param>
		/// <param name="scaleWidth">optional Int32 ScaleWidth = 0</param>
		/// <param name="scaleHeight">optional Int32 ScaleHeight = 0</param>
		/// <param name="exportMode">optional NetOffice.PowerPointApi.Enums.PpExportMode ExportMode = 1</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Export(string pathName, NetOffice.PowerPointApi.Enums.PpShapeFormat filter, object scaleWidth, object scaleHeight, object exportMode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pathName, filter, scaleWidth, scaleHeight, exportMode);
			Invoker.Method(this, "Export", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// 
		/// </summary>
		/// <param name="pathName">string PathName</param>
		/// <param name="filter">NetOffice.PowerPointApi.Enums.PpShapeFormat Filter</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Export(string pathName, NetOffice.PowerPointApi.Enums.PpShapeFormat filter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pathName, filter);
			Invoker.Method(this, "Export", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// 
		/// </summary>
		/// <param name="pathName">string PathName</param>
		/// <param name="filter">NetOffice.PowerPointApi.Enums.PpShapeFormat Filter</param>
		/// <param name="scaleWidth">optional Int32 ScaleWidth = 0</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Export(string pathName, NetOffice.PowerPointApi.Enums.PpShapeFormat filter, object scaleWidth)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pathName, filter, scaleWidth);
			Invoker.Method(this, "Export", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// 
		/// </summary>
		/// <param name="pathName">string PathName</param>
		/// <param name="filter">NetOffice.PowerPointApi.Enums.PpShapeFormat Filter</param>
		/// <param name="scaleWidth">optional Int32 ScaleWidth = 0</param>
		/// <param name="scaleHeight">optional Int32 ScaleHeight = 0</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public void Export(string pathName, NetOffice.PowerPointApi.Enums.PpShapeFormat filter, object scaleWidth, object scaleHeight)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pathName, filter, scaleWidth, scaleHeight);
			Invoker.Method(this, "Export", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// 
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public void CanvasCropLeft(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "CanvasCropLeft", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// 
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public void CanvasCropTop(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "CanvasCropTop", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// 
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public void CanvasCropRight(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "CanvasCropRight", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// 
		/// </summary>
		/// <param name="increment">Single Increment</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15,16)]
		public void CanvasCropBottom(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "CanvasCropBottom", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745536.aspx
		/// </summary>
		/// <param name="layout">NetOffice.OfficeApi.SmartArtLayout Layout</param>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public void ConvertTextToSmartArt(NetOffice.OfficeApi.SmartArtLayout layout)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(layout);
			Invoker.Method(this, "ConvertTextToSmartArt", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744204.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public void PickupAnimation()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PickupAnimation", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746525.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public void ApplyAnimation()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyAnimation", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744739.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public void UpgradeMedia()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpgradeMedia", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}