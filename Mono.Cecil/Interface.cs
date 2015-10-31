//
// Author:
//   Jb Evain (jbevain@gmail.com)
//
// Copyright (c) 2008 - 2015 Jb Evain
// Copyright (c) 2008 - 2011 Novell, Inc.
//
// Licensed under the MIT/X11 license.
//

using Mono.Collections.Generic;

namespace Mono.Cecil {

	public sealed class Interface : ICustomAttributeProvider
	{

		internal MetadataToken token;
		TypeReference interface_type;
		TypeDefinition owner_type;
		Collection<CustomAttribute> custom_attributes;

		public Interface (TypeReference interfaceType)
		{
			interface_type = interfaceType;
		}

		public MetadataToken MetadataToken
		{
			get { return token; }
			set { token = value; }
		}

		public TypeReference InterfaceType
		{
			get { return interface_type; }
			set { interface_type = value; }
		}

		public TypeDefinition OwnerType
		{
			get { return owner_type; }
			set { owner_type = value; }
		}

		public bool HasCustomAttributes
		{
			get
			{
				if (custom_attributes != null)
					return custom_attributes.Count > 0;

				return this.GetHasCustomAttributes (interface_type.Module);
			}
		}

		public Collection<CustomAttribute> CustomAttributes
		{
			get { return custom_attributes ?? (this.GetCustomAttributes (ref custom_attributes, interface_type.Module)); }
		}
	}
}
