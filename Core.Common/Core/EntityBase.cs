﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Core
{
	[DataContract]
	public abstract class EntityBase : IExtensibleDataObject
	{
		#region IExtensibleDataObject Members

		public ExtensionDataObject ExtensionData { get; set; }

		#endregion
	}
}
