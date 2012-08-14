﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using NHibernate.Mapping.ByCode;

namespace N2.Configuration
{
	public class ChildrenElement : ConfigurationElement
	{
		/// <summary>The type of nhibernate laziness to use. Supported values are "true", "false", and "extra".</summary>
		[ConfigurationProperty("laziness", DefaultValue = CollectionLazy.Extra)]
		public CollectionLazy Laziness
		{
			get { return (CollectionLazy)base["laziness"]; }
			set { base["laziness"] = value; }
		}

		/// <summary>The type of nhibernate cascade to use. Supported values are "None", "All", and the other cascade options provided by nhibernate.</summary>
		[ConfigurationProperty("cascade", DefaultValue = Cascade.All)]
		public Cascade Cascade
		{
			get { return (Cascade)base["cascade"]; }
			set { base["cascade"] = value; }
		}
	}
}
