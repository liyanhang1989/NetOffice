﻿using System;
using NetOffice;
namespace NetOffice.AccessApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197058.aspx </remarks>
	[SupportByVersionAttribute("Access", 9,10,11,12,14,15,16)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum AcModuleType
	{
		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15,16)]
		 acStandardModule = 0,

		 /// <summary>
		 /// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Access", 9,10,11,12,14,15,16)]
		 acClassModule = 1
	}
}